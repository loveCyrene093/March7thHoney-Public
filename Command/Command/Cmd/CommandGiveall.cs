using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.TrainParty;
using March7thHoney.Enums.Avatar;
using March7thHoney.Enums.Item;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Internationalization;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("giveall", "Game.Command.GiveAll.Desc", "Game.Command.GiveAll.Usage", new string[] { "ga" }, "", "")]
public class CommandGiveall : ICommand
{
	[CommandMethod("0 avatar")]
	public async ValueTask GiveAllAvatar(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		arg.CharacterArgs.TryGetValue("r", out string value);
		arg.CharacterArgs.TryGetValue("l", out string value2);
		if (value == null)
		{
			value = "0";
		}
		if (value2 == null)
		{
			value2 = "1";
		}
		if (!int.TryParse(value, out var rank) || !int.TryParse(value2, out var level))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		await GiveAllPath(arg);
		int clampedLevel = Math.Clamp(level, 1, 80);
		int clampedRank = Math.Clamp(rank, 0, 6);
		int promotion = GameData.GetMinPromotionForLevel(clampedLevel);
		Dictionary<int, AvatarConfigExcel>.ValueCollection values = GameData.AvatarConfigData.Values;
		foreach (AvatarConfigExcel avatar in values)
		{
			if ((avatar.AvatarID > 2000 && avatar.AvatarID != 8001) || (GameData.MultiplePathAvatarConfigData.TryGetValue(avatar.AvatarID, out MultiplePathAvatarConfigExcel value3) && avatar.AvatarID != value3.BaseAvatarID))
			{
				continue;
			}
			try
			{
				if (player.AvatarManager.GetFormalAvatar(avatar.AvatarID) == null)
				{
					await player.InventoryManager.AddItem(avatar.AvatarID, 1, notify: false, 1, 1, sync: false);
				}
				FormalAvatarInfo formalAvatar = player.AvatarManager.GetFormalAvatar(avatar.AvatarID);
				if (formalAvatar != null)
				{
					formalAvatar.Level = clampedLevel;
					formalAvatar.Promotion = promotion;
					formalAvatar.GetCurPathInfo().Rank = clampedRank;
				}
			}
			catch (Exception)
			{
			}
		}
		await player.SendPacket(new PacketPlayerSyncScNotify(player.AvatarManager.AvatarData.FormalAvatars));
		await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.Avatar"), "1"));
	}

	[CommandMethod("0 equipment")]
	public async ValueTask GiveAllLightcone(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		arg.CharacterArgs.TryGetValue("r", out string value);
		arg.CharacterArgs.TryGetValue("l", out string value2);
		arg.CharacterArgs.TryGetValue("x", out string value3);
		if (value == null)
		{
			value = "1";
		}
		if (value2 == null)
		{
			value2 = "1";
		}
		if (value3 == null)
		{
			value3 = "1";
		}
		if (!int.TryParse(value, out var rank) || !int.TryParse(value2, out var level) || !int.TryParse(value3, out var amount))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		Dictionary<int, EquipmentConfigExcel>.ValueCollection lightconeList = GameData.EquipmentConfigData.Values;
		List<ItemData> items = new List<ItemData>();
		for (int i = 0; i < amount; i++)
		{
			foreach (EquipmentConfigExcel item in lightconeList)
			{
				ItemData itemData = await player.InventoryManager.AddItem(item.EquipmentID, 1, notify: false, Math.Max(Math.Min(rank, 5), 0), Math.Max(Math.Min(level, 80), 0), sync: false);
				if (itemData != null)
				{
					items.Add(itemData);
				}
			}
		}
		await player.SendPacket(new PacketPlayerSyncScNotify(items));
		await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.Equipment"), amount.ToString()));
	}

	[CommandMethod("0 material")]
	public async ValueTask GiveAllMaterial(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		arg.CharacterArgs.TryGetValue("x", out string value);
		if (value == null)
		{
			value = "1";
		}
		if (!int.TryParse(value, out var amount))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		Dictionary<int, ItemConfigExcel>.ValueCollection values = GameData.ItemConfigData.Values;
		List<ItemData> list = new List<ItemData>();
		foreach (ItemConfigExcel item in values)
		{
			if (item.ItemMainType == ItemMainTypeEnum.Material || item.ItemSubType == ItemSubTypeEnum.Food || item.ItemSubType == ItemSubTypeEnum.FindChest)
			{
				list.Add(new ItemData
				{
					ItemId = item.ID,
					Count = amount
				});
			}
		}
		await playerInstance.InventoryManager.AddItems(list, notify: false);
		await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.Material"), amount.ToString()));
	}

	[CommandMethod("0 pet")]
	public async ValueTask GiveAllPet(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		arg.CharacterArgs.TryGetValue("x", out string value);
		if (value == null)
		{
			value = "1";
		}
		if (!int.TryParse(value, out var result))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		Dictionary<int, ItemConfigExcel>.ValueCollection values = GameData.ItemConfigData.Values;
		List<ItemData> list = new List<ItemData>();
		foreach (ItemConfigExcel item in values)
		{
			if (item.ItemMainType == ItemMainTypeEnum.Pet)
			{
				list.Add(new ItemData
				{
					ItemId = item.ID,
					Count = result
				});
			}
		}
		await playerInstance.InventoryManager.AddItems(list);
		await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.Pet"), "1"));
	}

	[CommandMethod("0 relic")]
	public async ValueTask GiveAllRelic(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		arg.CharacterArgs.TryGetValue("l", out string value);
		if (value == null)
		{
			value = "1";
		}
		if (!int.TryParse(value, out var level))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		arg.CharacterArgs.TryGetValue("x", out string value2);
		if (value2 == null)
		{
			value2 = "1";
		}
		if (!int.TryParse(value2, out var amount))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		Dictionary<int, RelicConfigExcel>.ValueCollection relicList = GameData.RelicConfigData.Values;
		List<ItemData> items = new List<ItemData>();
		for (int i = 0; i < amount; i++)
		{
			foreach (RelicConfigExcel item in relicList)
			{
				ItemData itemData = await player.InventoryManager.AddItem(item.ID, amount, notify: false, 1, Math.Max(Math.Min(level, item.MaxLevel), 1), sync: false);
				if (itemData != null)
				{
					items.Add(itemData);
				}
			}
		}
		await player.SendPacket(new PacketPlayerSyncScNotify(items));
		await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.Relic"), amount.ToString()));
	}

	[CommandMethod("0 unlock")]
	public async ValueTask GiveAllUnlock(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		Dictionary<int, ItemConfigExcel>.ValueCollection values = GameData.ItemConfigData.Values;
		foreach (ItemConfigExcel item in values)
		{
			if (item.ItemMainType == ItemMainTypeEnum.Usable && (item.ItemSubType == ItemSubTypeEnum.HeadIcon || item.ItemSubType == ItemSubTypeEnum.PhoneTheme || item.ItemSubType == ItemSubTypeEnum.ChatBubble || item.ItemSubType == ItemSubTypeEnum.PersonalCard || item.ItemSubType == ItemSubTypeEnum.PhoneCase || item.ItemSubType == ItemSubTypeEnum.AvatarSkin))
			{
				await player.InventoryManager.AddItem(item.ID, 1, notify: false);
			}
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.Unlock"), "1"));
	}

	[CommandMethod("0 train")]
	public async ValueTask GiveAllTrainItem(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		player.TrainPartyManager.Data.Fund = 1000000;
		player.TrainPartyManager.Data.Areas.Clear();
		foreach (KeyValuePair<int, TrainPartyAreaConfigExcel> item in GameData.TrainPartyAreaConfigData.Where<KeyValuePair<int, TrainPartyAreaConfigExcel>>((KeyValuePair<int, TrainPartyAreaConfigExcel> excel) => !player.TrainPartyManager.Data.Areas.ContainsKey(excel.Key)))
		{
			player.TrainPartyManager.Data.Areas[item.Key] = new TrainAreaInfo
			{
				AreaId = item.Key,
				StepList = new List<int>()
			};
		}
		foreach (KeyValuePair<int, TrainAreaInfo> area in player.TrainPartyManager.Data.Areas)
		{
			foreach (TrainPartyStepConfigExcel item2 in GameData.TrainPartyStepConfigData.Values.Where((TrainPartyStepConfigExcel stepExcel) => GameData.TrainPartyAreaGoalConfigData.FirstOrDefault<KeyValuePair<int, TrainPartyAreaGoalConfigExcel>>((KeyValuePair<int, TrainPartyAreaGoalConfigExcel> x) => x.Value.AreaID == area.Value.AreaId).Value.StepGroupList.Contains(stepExcel.GroupID)))
			{
				area.Value.StepList.Add(item2.ID);
			}
		}
		foreach (FloorInfo value in GameData.FloorInfoData.Values)
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			foreach (FloorSavedValueInfo item3 in value.FloorSavedValue)
			{
				if (item3.Name.StartsWith("Build_") || item3.Name == "Onboarded")
				{
					dictionary[item3.Name] = 1;
				}
				else if (item3.Name.StartsWith("Progress_"))
				{
					dictionary[item3.Name] = 100;
				}
				else if (item3.Name.StartsWith("Connection_") || item3.Name.StartsWith("Utility_"))
				{
					dictionary[item3.Name] = 0;
				}
			}
			if (dictionary.Count > 0)
			{
				player.SceneData.FloorSavedData[value.FloorID] = dictionary;
			}
		}
		await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.TrainParty"), "1"));
	}

	[CommandMethod("0 path")]
	public async ValueTask GiveAllPath(CommandArg arg)
	{
		PlayerInstance player = arg.Target?.Player;
		if (player == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		foreach (MultiplePathAvatarConfigExcel multiPathAvatar in GameData.MultiplePathAvatarConfigData.Values)
		{
			if (player.AvatarManager.GetFormalAvatar(multiPathAvatar.BaseAvatarID) == null)
			{
				await player.InventoryManager.AddItem(multiPathAvatar.BaseAvatarID, 1, notify: false, 1, 1, sync: false);
				player.AvatarManager.GetFormalAvatar(multiPathAvatar.BaseAvatarID).Level = Math.Max(Math.Min(1, 80), 0);
				player.AvatarManager.GetFormalAvatar(multiPathAvatar.BaseAvatarID).Promotion = GameData.GetMinPromotionForLevel(Math.Max(Math.Min(1, 80), 0));
				player.AvatarManager.GetFormalAvatar(multiPathAvatar.BaseAvatarID).GetCurPathInfo().Rank = Math.Max(Math.Min(0, 6), 0);
			}
			if (!player.AvatarManager.GetFormalAvatar(multiPathAvatar.BaseAvatarID).PathInfos.ContainsKey(multiPathAvatar.AvatarID) && (multiPathAvatar.BaseAvatarID <= 8000 || multiPathAvatar.AvatarID % 2 == 1))
			{
				await player.ChangeAvatarPathType(multiPathAvatar.BaseAvatarID, (MultiPathAvatarTypeEnum)multiPathAvatar.AvatarID);
			}
		}
		await player.SendPacket(new PacketPlayerSyncScNotify(player.AvatarManager.AvatarData.FormalAvatars));
		await arg.SendMsg(I18NManager.Translate("Game.Command.GiveAll.GiveAllItems", I18NManager.Translate("Word.Avatar"), "1"));
	}
}
