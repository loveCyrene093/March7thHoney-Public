using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Data.Freesr;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Calyx;
using March7thHoney.Database.Inventory;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Internationalization;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Calyx;

public static class FreesrShared
{
	public static readonly string[] JsonDirectoryRelativePaths = new string[1] { "Config/Json" };

	public static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
	{
		PropertyNameCaseInsensitive = true,
		ReadCommentHandling = JsonCommentHandling.Skip,
		AllowTrailingCommas = true
	};

	public static List<DirectoryInfo> GetJsonDirectories(bool createIfMissing = false)
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

	public static List<FileInfo> GetJsonFiles()
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

	public static ValueTask<(List<FormalAvatarInfo> changedAvatars, List<ItemData> removedItems)> ClearRelicAndEquipment(PlayerInstance player)
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
				foreach (int item3 in (from kv in pathInfo2.Relic
					where kv.Value == item2.UniqueId
					select kv.Key).ToList())
				{
					pathInfo2.Relic.Remove(item3);
				}
			}
			item2.EquipAvatar = 0;
			MarkChanged(formalAvatarInfo2);
		}
		List<ItemData> list = new List<ItemData>(data.EquipmentItems.Count + data.RelicItems.Count);
		list.AddRange(data.EquipmentItems.Select(delegate(ItemData x)
		{
			ItemData itemData = x.Clone();
			itemData.Count = 0;
			return itemData;
		}));
		list.AddRange(data.RelicItems.Select(delegate(ItemData x)
		{
			ItemData itemData = x.Clone();
			itemData.Count = 0;
			return itemData;
		}));
		data.EquipmentItems.Clear();
		data.RelicItems.Clear();
		return ValueTask.FromResult((changed.Values.ToList(), list));
		void MarkChanged(FormalAvatarInfo avatar)
		{
			if (!changed.ContainsKey(avatar.AvatarId))
			{
				changed.Add(avatar.AvatarId, avatar);
			}
		}
	}

	public static async ValueTask<List<FormalAvatarInfo>> ImportAvatars(PlayerInstance player, FreesrCalyxData data, Func<string, ValueTask>? sendMsg = null)
	{
		Dictionary<int, FormalAvatarInfo> changed = new Dictionary<int, FormalAvatarInfo>();
		if (data.Avatars == null || data.Avatars.Count == 0)
		{
			return new List<FormalAvatarInfo>();
		}
		foreach (KeyValuePair<int, FreesrCalyxAvatar> avatar in data.Avatars)
		{
			avatar.Deconstruct(out var key, out var value);
			int num = key;
			FreesrCalyxAvatar avatarJson = value;
			int avatarId = ((avatarJson.AvatarId > 0) ? avatarJson.AvatarId : num);
			MultiplePathAvatarConfigExcel value2;
			int baseAvatarId = (GameData.MultiplePathAvatarConfigData.TryGetValue(avatarId, out value2) ? value2.BaseAvatarID : avatarId);
			if (!GameData.AvatarConfigData.ContainsKey(avatarId))
			{
				if (sendMsg != null)
				{
					await sendMsg(I18NManager.Translate("Game.Command.Json.AvatarExcelNotFound", avatarId.ToString()));
				}
				continue;
			}
			if (player.AvatarManager?.GetFormalAvatar(baseAvatarId) == null)
			{
				await player.InventoryManager.AddItem(baseAvatarId, 1, notify: false, 1, 1, 0, sync: false);
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
				int num2 = avatarJson.EnhancedId.GetValueOrDefault();
				if (GameData.AvatarConfigData.TryGetValue(pathInfo.PathId, out AvatarConfigExcel value3) && !value3.SkillTree.ContainsKey(num2) && !value3.DefaultSkillTree.ContainsKey(num2))
				{
					num2 = 0;
				}
				int enhanceId = pathInfo.EnhanceId;
				pathInfo.EnhanceId = num2;
				try
				{
					Dictionary<int, int> skillTree = pathInfo.GetSkillTree();
					skillTree.Clear();
					foreach (KeyValuePair<int, int> skill in avatarJson.Data.Skills)
					{
						skill.Deconstruct(out key, out var value4);
						int key2 = key;
						int val = value4;
						skillTree[key2] = Math.Max(1, val);
					}
				}
				finally
				{
					pathInfo.EnhanceId = enhanceId;
				}
			}
			changed[formalAvatarInfo.BaseAvatarId] = formalAvatarInfo;
		}
		return changed.Values.ToList();
	}

	public static async ValueTask<List<ItemData>> ImportRelicsAndLightcones(PlayerInstance player, FreesrCalyxData data, List<FormalAvatarInfo> avatarChanged)
	{
		List<ItemData> importedItems = new List<ItemData>(Math.Max(16, (data.Relics?.Count ?? 0) + (data.Lightcones?.Count ?? 0)));
		Dictionary<int, FormalAvatarInfo> avatarChangedMap = avatarChanged.ToDictionary((FormalAvatarInfo x) => x.BaseAvatarId, (FormalAvatarInfo x) => x);
		if (data.Relics != null)
		{
			foreach (FreesrCalyxRelic relic in data.Relics)
			{
				if (!GameData.RelicConfigData.TryGetValue(relic.RelicId, out RelicConfigExcel relicConfig) || !GameData.ItemConfigData.TryGetValue(relic.RelicId, out ItemConfigExcel value) || value.ItemMainType != ItemMainTypeEnum.Relic || !GameData.RelicMainAffixData.TryGetValue(relicConfig.MainAffixGroup, out Dictionary<int, RelicMainAffixConfigExcel> value2) || value2.Count == 0)
				{
					continue;
				}
				List<ItemSubAffix> list = new List<ItemSubAffix>(relic.SubAffixes?.Count ?? 0);
				if (relic.SubAffixes != null && GameData.RelicSubAffixData.TryGetValue(relicConfig.SubAffixGroup, out Dictionary<int, RelicSubAffixConfigExcel> value3) && value3 != null)
				{
					foreach (FreesrCalyxRelicSubAffix subAffix in relic.SubAffixes)
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
				ItemData itemData = await player.InventoryManager.PutItem(relic.RelicId, 1, 0, 0, Math.Max(0, relic.Level), 0, 0, mainAffix, list, null, ++player.InventoryManager.Data.NextUniqueId);
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
					itemData.EquipAvatar = formalAvatarInfo.BaseAvatarId;
				}
				relicConfig = null;
			}
		}
		if (data.Lightcones != null)
		{
			foreach (FreesrCalyxLightcone lightcone in data.Lightcones)
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
						itemData2.EquipAvatar = formalAvatarInfo2.BaseAvatarId;
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

	public static async ValueTask ImportJson(string json, PlayerInstance player, Func<string[], System.Threading.Tasks.Task> sendI18nCallback)
	{
		FreesrCalyxData data = DeserializeFreesrPayload(json);
		if (data == null)
		{
			await sendI18nCallback(new string[1] { "Game.Command.Json.InvalidJsonContent" });
			return;
		}
		List<FormalAvatarInfo> list;
		List<ItemData> clearedItems;
		(list, clearedItems) = await ClearRelicAndEquipment(player);
		if (list.Count > 0)
		{
			await player.SendPacket(new PacketPlayerSyncScNotify(list));
		}
		if (clearedItems.Count > 0)
		{
			await player.SendPacket(new PacketPlayerSyncScNotify(clearedItems));
		}
		List<FormalAvatarInfo> avatarChanged = await ImportAvatars(player, data);
		List<ItemData> list2 = await ImportRelicsAndLightcones(player, data, avatarChanged);
		if (list2.Count > 0)
		{
			await player.SendPacket(new PacketPlayerSyncScNotify(list2));
		}
		if (avatarChanged.Count > 0)
		{
			await player.SendPacket(new PacketPlayerSyncScNotify(avatarChanged));
		}
		if (player.CalyxOverrideManager != null && (data.BattleConfig != null || data.Avatars != null))
		{
			CalyxOverrideData data2 = player.CalyxOverrideManager.Data;
			CalyxOverrideData calyxOverrideData = data2;
			if (calyxOverrideData.CachedJson == null)
			{
				calyxOverrideData.CachedJson = new FreesrCalyxData();
			}
			if (data.BattleConfig != null)
			{
				data2.CachedJson.BattleConfig = data.BattleConfig;
			}
			if (data.Avatars != null)
			{
				data2.CachedJson.Avatars = data.Avatars;
			}
			DatabaseHelper.ToSaveUidList.SafeAdd(player.Uid);
		}
		DatabaseHelper.ToSaveUidList.SafeAdd(player.Uid);
		await sendI18nCallback(new string[4]
		{
			"Game.Command.Json.ImportSummary",
			(data.Avatars?.Count ?? 0).ToString(),
			(data.Relics?.Count ?? 0).ToString(),
			(data.Lightcones?.Count ?? 0).ToString()
		});
	}

	private static FreesrCalyxData? DeserializeFreesrPayload(string json)
	{
		FreesrCalyxData freesrCalyxData = JsonSerializer.Deserialize<FreesrCalyxData>(json, JsonOptions);
		if (freesrCalyxData == null)
		{
			return null;
		}
		try
		{
			using JsonDocument jsonDocument = JsonDocument.Parse(json);
			JsonElement rootElement = jsonDocument.RootElement;
			if (freesrCalyxData.BattleConfig == null && rootElement.TryGetProperty("battleConfig", out var value))
			{
				freesrCalyxData.BattleConfig = JsonSerializer.Deserialize<FreesrBattleConfig>(value.GetRawText(), JsonOptions);
			}
			if ((freesrCalyxData.Lightcones == null || freesrCalyxData.Lightcones.Count == 0) && rootElement.TryGetProperty("lightCones", out var value2))
			{
				freesrCalyxData.Lightcones = JsonSerializer.Deserialize<List<FreesrCalyxLightcone>>(value2.GetRawText(), JsonOptions) ?? new List<FreesrCalyxLightcone>();
			}
		}
		catch
		{
		}
		return freesrCalyxData;
	}

	public static async ValueTask<string> ExportPlayerDataAsync(int uid, bool writeIndented)
	{
		FreesrCalyxData freesrCalyxData = new FreesrCalyxData
		{
			Avatars = new Dictionary<int, FreesrCalyxAvatar>(),
			Relics = new List<FreesrCalyxRelic>(),
			Lightcones = new List<FreesrCalyxLightcone>()
		};
		DatabaseHelper instance = DatabaseHelper.Instance;
		if (instance == null)
		{
			throw new Exception("DatabaseHelper not initialized.");
		}
		CalyxOverrideData instance2 = instance.GetInstance<CalyxOverrideData>(uid);
		Dictionary<int, FreesrCalyxAvatar> dictionary = instance2?.CachedJson?.Avatars;
		AvatarData instance3 = instance.GetInstance<AvatarData>(uid);
		if (instance3 != null)
		{
			foreach (FormalAvatarInfo formalAvatar in instance3.FormalAvatars)
			{
				foreach (PathInfo value2 in formalAvatar.PathInfos.Values)
				{
					FreesrCalyxAvatar value = null;
					dictionary?.TryGetValue(value2.PathId, out value);
					freesrCalyxData.Avatars[value2.PathId] = new FreesrCalyxAvatar
					{
						AvatarId = value2.PathId,
						Level = formalAvatar.Level,
						Promotion = formalAvatar.Promotion,
						EnhancedId = (value?.EnhancedId ?? value2.EnhanceId),
						SpValue = value?.SpValue,
						SpMax = value?.SpMax,
						Techniques = value?.Techniques,
						Data = new FreesrCalyxAvatarExtra
						{
							Rank = value2.Rank,
							Skills = value2.GetSkillTree().ToDictionary((KeyValuePair<int, int> kv) => kv.Key, (KeyValuePair<int, int> kv) => kv.Value)
						}
					};
				}
			}
		}
		InventoryData instance4 = instance.GetInstance<InventoryData>(uid);
		if (instance4 != null)
		{
			foreach (ItemData relicItem in instance4.RelicItems)
			{
				freesrCalyxData.Relics.Add(new FreesrCalyxRelic
				{
					Level = relicItem.Level,
					RelicId = relicItem.ItemId,
					MainAffixId = relicItem.MainAffix,
					EquipAvatar = relicItem.EquipAvatar,
					SubAffixes = relicItem.SubAffixes?.Select((ItemSubAffix sa) => new FreesrCalyxRelicSubAffix
					{
						SubAffixId = sa.Id,
						Count = sa.Count,
						Step = sa.Step
					}).ToList()
				});
			}
			foreach (ItemData equipmentItem in instance4.EquipmentItems)
			{
				freesrCalyxData.Lightcones.Add(new FreesrCalyxLightcone
				{
					ItemId = equipmentItem.ItemId,
					Level = equipmentItem.Level,
					Rank = equipmentItem.Rank,
					Promotion = equipmentItem.Promotion,
					EquipAvatar = equipmentItem.EquipAvatar
				});
			}
		}
		if (instance2?.CachedJson?.BattleConfig != null)
		{
			freesrCalyxData.BattleConfig = instance2.CachedJson.BattleConfig;
		}
		return await System.Threading.Tasks.Task.FromResult(JsonSerializer.Serialize(freesrCalyxData, new JsonSerializerOptions
		{
			WriteIndented = writeIndented,
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
		}));
	}
}
