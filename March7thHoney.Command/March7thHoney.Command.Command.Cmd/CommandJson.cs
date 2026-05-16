using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Internationalization;
using March7thHoney.Util;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("json", "Game.Command.Json.Desc", "Game.Command.Json.Usage", "", "")]
public class CommandJson : ICommand
{
	private sealed class FreeSrData
	{
		[JsonPropertyName("relics")]
		public List<RelicJson>? Relics { get; set; }

		[JsonPropertyName("lightcones")]
		public List<LightconeJson>? Lightcones { get; set; }

		[JsonPropertyName("avatars")]
		public Dictionary<int, AvatarJson>? Avatars { get; set; }
	}

	private sealed class RelicJson
	{
		[JsonPropertyName("level")]
		public int Level { get; set; }

		[JsonPropertyName("relic_id")]
		public int RelicId { get; set; }

		[JsonPropertyName("main_affix_id")]
		public int MainAffixId { get; set; }

		[JsonPropertyName("equip_avatar")]
		public int EquipAvatar { get; set; }

		[JsonPropertyName("sub_affixes")]
		public List<RelicSubAffixJson>? SubAffixes { get; set; }
	}

	private sealed class RelicSubAffixJson
	{
		[JsonPropertyName("sub_affix_id")]
		public int SubAffixId { get; set; }

		[JsonPropertyName("count")]
		public int Count { get; set; }

		[JsonPropertyName("step")]
		public int Step { get; set; }
	}

	private sealed class LightconeJson
	{
		[JsonPropertyName("level")]
		public int Level { get; set; }

		[JsonPropertyName("equip_avatar")]
		public int EquipAvatar { get; set; }

		[JsonPropertyName("item_id")]
		public int ItemId { get; set; }

		[JsonPropertyName("rank")]
		public int Rank { get; set; }

		[JsonPropertyName("promotion")]
		public int Promotion { get; set; }
	}

	private sealed class AvatarJson
	{
		[JsonPropertyName("avatar_id")]
		public int AvatarId { get; set; }

		[JsonPropertyName("level")]
		public int Level { get; set; }

		[JsonPropertyName("promotion")]
		public int Promotion { get; set; }

		[JsonPropertyName("data")]
		public AvatarExtraJson? Data { get; set; }
	}

	private sealed class AvatarExtraJson
	{
		[JsonPropertyName("rank")]
		public int Rank { get; set; }

		[JsonPropertyName("skills")]
		public Dictionary<int, int>? Skills { get; set; }
	}

	private static readonly string[] JsonDirectoryRelativePaths = new string[1] { "Config/Json" };

	private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
	{
		PropertyNameCaseInsensitive = true,
		ReadCommentHandling = JsonCommentHandling.Skip,
		AllowTrailingCommas = true
	};

	private static List<DirectoryInfo> GetJsonDirectories(bool createIfMissing = false)
	{
		List<DirectoryInfo> list = new List<DirectoryInfo>(JsonDirectoryRelativePaths.Length);
		string[] jsonDirectoryRelativePaths = JsonDirectoryRelativePaths;
		foreach (string text in jsonDirectoryRelativePaths)
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetFullPath(text));
			if (createIfMissing && !directoryInfo.Exists && text.Equals("Config/Json", StringComparison.OrdinalIgnoreCase))
			{
				directoryInfo.Create();
			}
			list.Add(directoryInfo);
		}
		return list;
	}

	[CommandDefault]
	public async ValueTask Import(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		string text = string.Join(" ", arg.BasicArgs).Trim();
		if (string.IsNullOrWhiteSpace(text))
		{
			await ShowFileList(arg);
			return;
		}
		if (text.Equals("clear", StringComparison.OrdinalIgnoreCase))
		{
			List<FormalAvatarInfo> list;
			List<ItemData> removedItems;
			(list, removedItems) = await ClearRelicAndEquipment(player);
			if (list.Count > 0)
			{
				await player.SendPacket(new PacketPlayerSyncScNotify(list));
			}
			if (removedItems.Count > 0)
			{
				await player.SendPacket(new PacketPlayerSyncScNotify(removedItems));
			}
			DatabaseHelper.ToSaveUidList.SafeAdd(player.Uid);
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.ClearInventory"));
			return;
		}
		string error;
		string selectedPath = ResolveInputPath(text, out error);
		if (selectedPath == null)
		{
			if (!string.IsNullOrWhiteSpace(error))
			{
				await arg.SendMsg(error);
			}
			return;
		}
		if (!File.Exists(selectedPath))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.FileNotFound", selectedPath));
			return;
		}
		FreeSrData data;
		try
		{
			data = JsonSerializer.Deserialize<FreeSrData>(await File.ReadAllTextAsync(selectedPath), JsonOptions);
		}
		catch (Exception ex)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.ReadOrParseFailed", ex.Message));
			return;
		}
		if (data == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.InvalidJsonContent"));
			return;
		}
		List<FormalAvatarInfo> list2;
		List<ItemData> clearedItems;
		(list2, clearedItems) = await ClearRelicAndEquipment(player);
		if (list2.Count > 0)
		{
			await player.SendPacket(new PacketPlayerSyncScNotify(list2));
		}
		if (clearedItems.Count > 0)
		{
			await player.SendPacket(new PacketPlayerSyncScNotify(clearedItems));
		}
		List<FormalAvatarInfo> avatarChanged = await ImportAvatars(player, data, arg);
		List<ItemData> list3 = await ImportRelicsAndLightcones(player, data, avatarChanged);
		if (list3.Count > 0)
		{
			await player.SendPacket(new PacketPlayerSyncScNotify(list3));
		}
		if (avatarChanged.Count > 0)
		{
			await player.SendPacket(new PacketPlayerSyncScNotify(avatarChanged));
		}
		DatabaseHelper.ToSaveUidList.SafeAdd(player.Uid);
		await arg.SendMsg(I18NManager.Translate("Game.Command.Json.ImportSummary", Path.GetFileName(selectedPath), (data.Avatars?.Count ?? 0).ToString(), (data.Relics?.Count ?? 0).ToString(), (data.Lightcones?.Count ?? 0).ToString()));
	}

	private static string? ResolveInputPath(string input, out string? error)
	{
		error = null;
		input = input.Trim();
		string text;
		if (input.Length >= 2 && input.StartsWith('"') && input.EndsWith('"'))
		{
			text = input;
			input = text.Substring(1, text.Length - 1 - 1);
		}
		if (int.TryParse(input, out var result))
		{
			List<FileInfo> list = (from f in GetJsonFiles()
				orderby f.LastWriteTimeUtc
				select f).ToList();
			if (list.Count == 0)
			{
				error = I18NManager.Translate("Game.Command.Json.NoFileFoundWithHint");
				return null;
			}
			if (result < 1 || result > list.Count)
			{
				error = I18NManager.Translate("Game.Command.Json.InvalidChoice", list.Count.ToString());
				return null;
			}
			return list[result - 1].FullName;
		}
		if (input.Contains('/') || input.Contains('\\') || Path.IsPathRooted(input))
		{
			return Path.GetFullPath(input);
		}
		List<DirectoryInfo> jsonDirectories = GetJsonDirectories(createIfMissing: true);
		string path = (input.EndsWith(".json", StringComparison.OrdinalIgnoreCase) ? input : (input + ".json"));
		foreach (DirectoryInfo item in jsonDirectories)
		{
			string text2 = Path.Combine(item.FullName, input);
			if (File.Exists(text2))
			{
				text = text2;
			}
			else
			{
				text2 = Path.Combine(item.FullName, path);
				if (!File.Exists(text2))
				{
					continue;
				}
				text = text2;
			}
			goto IL_019e;
		}
		return Path.Combine(jsonDirectories[0].FullName, path);
		IL_019e:
		return text;
	}

	private static List<FileInfo> GetJsonFiles()
	{
		List<DirectoryInfo> jsonDirectories = GetJsonDirectories(createIfMissing: true);
		try
		{
			return jsonDirectories.Where((DirectoryInfo x) => x.Exists).SelectMany((DirectoryInfo x) => x.GetFiles("*.json", SearchOption.TopDirectoryOnly)).DistinctBy((FileInfo x) => x.FullName)
				.ToList();
		}
		catch
		{
			return new List<FileInfo>();
		}
	}

	private static async ValueTask ShowFileList(CommandArg arg)
	{
		List<FileInfo> files = (from f in GetJsonFiles()
			orderby f.LastWriteTimeUtc
			select f).ToList();
		if (files.Count == 0)
		{
			List<string> searched = (from x in GetJsonDirectories(createIfMissing: true)
				select x.FullName).ToList();
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.NoFileFound"));
			if (searched.Count <= 0)
			{
				return;
			}
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.SearchedDirectories"));
			foreach (string item in searched)
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Json.SearchedDirectoryItem", item));
			}
		}
		else
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.FoundFiles"));
			for (int i = 0; i < files.Count; i++)
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Json.FileListItem", (i + 1).ToString(), files[i].Name));
			}
			await arg.SendMsg(I18NManager.Translate("Game.Command.Json.UsageSelectHint"));
		}
	}

	private static async ValueTask<(List<FormalAvatarInfo> changedAvatars, List<ItemData> removedItems)> ClearRelicAndEquipment(PlayerInstance player)
	{
		Dictionary<int, FormalAvatarInfo> changed = new Dictionary<int, FormalAvatarInfo>();
		InventoryData data = player.InventoryManager.Data;
		foreach (ItemData item in data.EquipmentItems)
		{
			if (item.EquipAvatar <= 0)
			{
				continue;
			}
			FormalAvatarInfo formalAvatarInfo = player.AvatarManager?.GetFormalAvatar(item.EquipAvatar);
			if (formalAvatarInfo != null)
			{
				PathInfo pathInfo = formalAvatarInfo.PathInfos.GetValueOrDefault(item.EquipAvatar) ?? formalAvatarInfo.PathInfos.Values.FirstOrDefault((PathInfo x) => x.EquipId == item.UniqueId);
				if (pathInfo != null && pathInfo.EquipId == item.UniqueId)
				{
					pathInfo.EquipId = 0;
				}
				item.EquipAvatar = 0;
				MarkChanged(formalAvatarInfo);
			}
		}
		foreach (ItemData item2 in data.RelicItems)
		{
			if (item2.EquipAvatar <= 0)
			{
				continue;
			}
			FormalAvatarInfo formalAvatarInfo2 = player.AvatarManager?.GetFormalAvatar(item2.EquipAvatar);
			if (formalAvatarInfo2 == null)
			{
				continue;
			}
			PathInfo pathInfo2 = formalAvatarInfo2.PathInfos.GetValueOrDefault(item2.EquipAvatar) ?? formalAvatarInfo2.PathInfos.Values.FirstOrDefault((PathInfo x) => x.Relic.Values.Contains(item2.UniqueId));
			if (pathInfo2 != null)
			{
				foreach (int item4 in (from kv in pathInfo2.Relic
					where kv.Value == item2.UniqueId
					select kv.Key).ToList())
				{
					pathInfo2.Relic.Remove(item4);
				}
			}
			item2.EquipAvatar = 0;
			MarkChanged(formalAvatarInfo2);
		}
		List<(int, int, int)> list = new List<(int, int, int)>(data.EquipmentItems.Count + data.RelicItems.Count);
		list.AddRange(data.EquipmentItems.Select((ItemData x) => (ItemId: x.ItemId, 1, UniqueId: x.UniqueId)));
		list.AddRange(data.RelicItems.Select((ItemData x) => (ItemId: x.ItemId, 1, UniqueId: x.UniqueId)));
		List<ItemData> item3 = await player.InventoryManager.RemoveItems(list, sync: false);
		return (changed.Values.ToList(), item3);
		void MarkChanged(FormalAvatarInfo avatar)
		{
			if (!changed.ContainsKey(avatar.AvatarId))
			{
				changed.Add(avatar.AvatarId, avatar);
			}
		}
	}

	private static async ValueTask<List<FormalAvatarInfo>> ImportAvatars(PlayerInstance player, FreeSrData data, CommandArg arg)
	{
		Dictionary<int, FormalAvatarInfo> changed = new Dictionary<int, FormalAvatarInfo>();
		if (data.Avatars == null || data.Avatars.Count == 0)
		{
			return new List<FormalAvatarInfo>();
		}
		foreach (KeyValuePair<int, AvatarJson> avatar in data.Avatars)
		{
			avatar.Deconstruct(out var key, out var value);
			int num = key;
			AvatarJson avatarJson = value;
			int avatarId = ((avatarJson.AvatarId > 0) ? avatarJson.AvatarId : num);
			MultiplePathAvatarConfigExcel value2;
			int baseAvatarId = (GameData.MultiplePathAvatarConfigData.TryGetValue(avatarId, out value2) ? value2.BaseAvatarID : avatarId);
			if (!GameData.AvatarConfigData.ContainsKey(avatarId))
			{
				await arg.SendMsg(I18NManager.Translate("Game.Command.Json.AvatarExcelNotFound", avatarId.ToString()));
				continue;
			}
			if (player.AvatarManager?.GetFormalAvatar(baseAvatarId) == null)
			{
				await player.InventoryManager.AddItem(baseAvatarId, 1, notify: false, 1, 1, sync: false);
			}
			FormalAvatarInfo formalAvatarInfo = player.AvatarManager?.GetFormalAvatar(baseAvatarId);
			if (formalAvatarInfo == null)
			{
				continue;
			}
			if (!formalAvatarInfo.PathInfos.ContainsKey(avatarId))
			{
				formalAvatarInfo.PathInfos[avatarId] = new PathInfo(avatarId);
				formalAvatarInfo.PathInfos[avatarId].GetSkillTree();
			}
			formalAvatarInfo.Level = Math.Clamp(avatarJson.Level, 1, 80);
			formalAvatarInfo.Promotion = ((avatarJson.Promotion > 0) ? Math.Clamp(avatarJson.Promotion, 0, 6) : GameData.GetMinPromotionForLevel(formalAvatarInfo.Level));
			PathInfo pathInfo = formalAvatarInfo.PathInfos[avatarId];
			pathInfo.Rank = Math.Clamp(avatarJson.Data?.Rank ?? 0, 0, 6);
			if (avatarJson.Data?.Skills != null)
			{
				Dictionary<int, int> skillTree = pathInfo.GetSkillTree();
				skillTree.Clear();
				foreach (KeyValuePair<int, int> skill in avatarJson.Data.Skills)
				{
					skill.Deconstruct(out key, out var value3);
					int key2 = key;
					int val = value3;
					skillTree[key2] = Math.Max(1, val);
				}
			}
			changed[formalAvatarInfo.BaseAvatarId] = formalAvatarInfo;
		}
		return changed.Values.ToList();
	}

	private static async ValueTask<List<ItemData>> ImportRelicsAndLightcones(PlayerInstance player, FreeSrData data, List<FormalAvatarInfo> avatarChanged)
	{
		List<ItemData> importedItems = new List<ItemData>(Math.Max(16, (data.Relics?.Count ?? 0) + (data.Lightcones?.Count ?? 0)));
		Dictionary<int, FormalAvatarInfo> avatarChangedMap = avatarChanged.ToDictionary((FormalAvatarInfo x) => x.BaseAvatarId, (FormalAvatarInfo x) => x);
		if (data.Relics != null)
		{
			foreach (RelicJson relic in data.Relics)
			{
				if (!GameData.RelicConfigData.TryGetValue(relic.RelicId, out RelicConfigExcel relicConfig) || !GameData.ItemConfigData.TryGetValue(relic.RelicId, out ItemConfigExcel value) || value.ItemMainType != ItemMainTypeEnum.Relic || !GameData.RelicMainAffixData.TryGetValue(relicConfig.MainAffixGroup, out Dictionary<int, RelicMainAffixConfigExcel> value2) || value2.Count == 0)
				{
					continue;
				}
				List<ItemSubAffix> list = new List<ItemSubAffix>(relic.SubAffixes?.Count ?? 0);
				if (relic.SubAffixes != null && GameData.RelicSubAffixData.TryGetValue(relicConfig.SubAffixGroup, out Dictionary<int, RelicSubAffixConfigExcel> value3) && value3 != null)
				{
					foreach (RelicSubAffixJson subAffix in relic.SubAffixes)
					{
						if (value3.ContainsKey(subAffix.SubAffixId))
						{
							list.Add(new ItemSubAffix
							{
								Id = subAffix.SubAffixId,
								Count = Math.Max(1, subAffix.Count),
								Step = Math.Max(0, subAffix.Step)
							});
						}
					}
				}
				int mainAffix = (value2.ContainsKey(relic.MainAffixId) ? relic.MainAffixId : value2.Keys.First());
				ItemData itemData = await player.InventoryManager.PutItem(relic.RelicId, 1, 0, 0, Math.Clamp(relic.Level, 0, relicConfig.MaxLevel), 0, 0, mainAffix, list, null, ++player.InventoryManager.Data.NextUniqueId);
				importedItems.Add(itemData);
				if (relic.EquipAvatar > 0)
				{
					int equipAvatar = relic.EquipAvatar;
					if (!GameData.AvatarConfigData.ContainsKey(equipAvatar))
					{
						continue;
					}
					FormalAvatarInfo formalAvatarInfo = GetAvatar(equipAvatar);
					if (formalAvatarInfo == null)
					{
						continue;
					}
					EnsurePath(formalAvatarInfo, equipAvatar);
					int type = (int)relicConfig.Type;
					formalAvatarInfo.PathInfos[equipAvatar].Relic[type] = itemData.UniqueId;
					itemData.EquipAvatar = equipAvatar;
				}
				relicConfig = null;
			}
		}
		if (data.Lightcones != null)
		{
			foreach (LightconeJson lightcone in data.Lightcones)
			{
				if (!GameData.ItemConfigData.TryGetValue(lightcone.ItemId, out ItemConfigExcel value4) || value4.ItemMainType != ItemMainTypeEnum.Equipment || !GameData.EquipmentConfigData.TryGetValue(lightcone.ItemId, out EquipmentConfigExcel value5))
				{
					continue;
				}
				ItemData itemData2 = await player.InventoryManager.PutItem(lightcone.ItemId, 1, Math.Clamp(lightcone.Rank, 1, Math.Max(1, value5.MaxRank)), Math.Clamp(lightcone.Promotion, 0, Math.Max(0, value5.MaxPromotion)), Math.Clamp(lightcone.Level, 1, 80), 0, 0, 0, null, null, ++player.InventoryManager.Data.NextUniqueId);
				importedItems.Add(itemData2);
				if (lightcone.EquipAvatar <= 0)
				{
					continue;
				}
				int equipAvatar2 = lightcone.EquipAvatar;
				if (GameData.AvatarConfigData.ContainsKey(equipAvatar2))
				{
					FormalAvatarInfo formalAvatarInfo2 = GetAvatar(equipAvatar2);
					if (formalAvatarInfo2 != null)
					{
						EnsurePath(formalAvatarInfo2, equipAvatar2);
						formalAvatarInfo2.PathInfos[equipAvatar2].EquipId = itemData2.UniqueId;
						itemData2.EquipAvatar = equipAvatar2;
					}
				}
			}
		}
		avatarChanged.Clear();
		avatarChanged.AddRange(avatarChangedMap.Values);
		return importedItems;
		static void EnsurePath(FormalAvatarInfo avatar, int avatarId)
		{
			if (!avatar.PathInfos.ContainsKey(avatarId))
			{
				avatar.PathInfos[avatarId] = new PathInfo(avatarId);
				avatar.PathInfos[avatarId].GetSkillTree();
			}
		}
		FormalAvatarInfo? GetAvatar(int pathOrBaseAvatarId)
		{
			MultiplePathAvatarConfigExcel value6;
			int num = (GameData.MultiplePathAvatarConfigData.TryGetValue(pathOrBaseAvatarId, out value6) ? value6.BaseAvatarID : pathOrBaseAvatarId);
			if (avatarChangedMap.TryGetValue(num, out var value7))
			{
				return value7;
			}
			FormalAvatarInfo formalAvatarInfo3 = player.AvatarManager?.GetFormalAvatar(num);
			if (formalAvatarInfo3 == null)
			{
				return null;
			}
			avatarChangedMap[num] = formalAvatarInfo3;
			return formalAvatarInfo3;
		}
	}
}
