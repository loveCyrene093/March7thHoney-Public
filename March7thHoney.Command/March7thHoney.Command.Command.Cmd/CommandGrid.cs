using System;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.GameServer.Game.GridFight;
using March7thHoney.GameServer.Game.GridFight.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.GridFight;
using March7thHoney.Internationalization;
using March7thHoney.Proto;

namespace March7thHoney.Command.Command.Cmd;

[CommandInfo("grid", "Game.Command.Grid.Desc", "Game.Command.Grid.Usage", "", "")]
public class CommandGrid : ICommand
{
	[CommandMethod("0 role")]
	public async ValueTask AddRole(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		GridFightInstance gridFightInstance = playerInstance?.GridFightManager?.GridFightInstance;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (gridFightInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.NotInGame"));
			return;
		}
		if (arg.BasicArgs.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		uint num = (uint)arg.GetInt(0);
		uint num2 = (uint)Math.Max(1, arg.GetInt(1));
		if (!GameData.GridFightRoleStarData.ContainsKey((num << 4) | num2))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.InvalidRole"));
			return;
		}
		uint num3 = gridFightInstance.AllocRoleUniqueId();
		gridFightInstance.RoleByUniqueId[num3] = num;
		gridFightInstance.RoleStarByUniqueId[num3] = num2;
		uint num4 = 0u;
		uint[] array = new uint[13]
		{
			14u, 15u, 16u, 17u, 18u, 6u, 7u, 8u, 9u, 10u,
			11u, 12u, 13u
		};
		foreach (uint num5 in array)
		{
			if (!gridFightInstance.UniqueIdByPos.ContainsKey(num5))
			{
				num4 = num5;
				break;
			}
		}
		if (num4 != 0)
		{
			gridFightInstance.UniqueIdByPos[num4] = num3;
		}
		GridGameRoleInfo gridGameRoleInfo = new GridGameRoleInfo
		{
			Id = num,
			Pos = num4,
			UniqueId = num3,
			RoleStar = num2
		};
		if (GameData.GridFightRoleBasicInfoData.TryGetValue(num, out GridFightRoleBasicInfoExcel value) && value.RoleSavedValueList.Count > 0)
		{
			gridGameRoleInfo.GridFightValueInitComponent[value.RoleSavedValueList[0]] = 0u;
		}
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			AddRoleInfo = gridGameRoleInfo
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		await playerInstance.SendPacket(new PacketGridFightSyncUpdateResultScNotify(gridFightSyncUpdateResultScNotify));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.AddedRole"));
	}

	[CommandMethod("0 gold")]
	public async ValueTask UpdateGold(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		GridFightInstance gridFightInstance = playerInstance?.GridFightManager?.GridFightInstance;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (gridFightInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.NotInGame"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		int delta = arg.GetInt(0);
		if (delta >= 0)
		{
			gridFightInstance.Gold += (uint)delta;
		}
		else
		{
			gridFightInstance.Gold = ((gridFightInstance.Gold >= (uint)(-delta)) ? (gridFightInstance.Gold - (uint)(-delta)) : 0u);
		}
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			ItemValue = gridFightInstance.Gold
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		await playerInstance.SendPacket(new PacketGridFightSyncUpdateResultScNotify(gridFightSyncUpdateResultScNotify));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.UpdateGold", delta.ToString()));
	}

	[CommandMethod("0 equip")]
	public async ValueTask AddEquipment(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		GridFightInstance gridFightInstance = playerInstance?.GridFightManager?.GridFightInstance;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (gridFightInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.NotInGame"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		uint equipmentId = (uint)arg.GetInt(0);
		if (!GameData.GridFightEquipmentData.ContainsKey(equipmentId))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.InvalidEquipment"));
			return;
		}
		GridFightEquipmentInfo item = new GridFightEquipmentInfo
		{
			GridFightEquipmentId = equipmentId,
			Source = 1u,
			UniqueId = gridFightInstance.AllocEquipUniqueId()
		};
		gridFightInstance.Equipments.Add(item);
		GridFightGameItemSyncInfo gridFightGameItemSyncInfo = new GridFightGameItemSyncInfo();
		gridFightGameItemSyncInfo.GridFightEquipmentList.Add(item);
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			AddGameItemInfo = gridFightGameItemSyncInfo
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		await playerInstance.SendPacket(new PacketGridFightSyncUpdateResultScNotify(gridFightSyncUpdateResultScNotify));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.AddEquipment", equipmentId.ToString()));
	}

	[CommandMethod("0 orb")]
	public async ValueTask AddOrb(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		GridFightInstance gridFightInstance = playerInstance?.GridFightManager?.GridFightInstance;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (gridFightInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.NotInGame"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		uint orbId = (uint)arg.GetInt(0);
		if (!GameData.GridFightOrbData.ContainsKey(orbId))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.InvalidOrb"));
			return;
		}
		uint num = gridFightInstance.AllocOrbUniqueId();
		gridFightInstance.OrbItemByUniqueId[num] = orbId;
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			OrbSyncInfo = new GridFightOrbSyncInfo
			{
				UniqueId = num,
				OrbItemId = orbId
			}
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		await playerInstance.SendPacket(new PacketGridFightSyncUpdateResultScNotify(gridFightSyncUpdateResultScNotify));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.AddOrb", orbId.ToString()));
	}

	[CommandMethod("0 consumable")]
	public async ValueTask AddConsumable(CommandArg arg)
	{
		PlayerInstance playerInstance = arg.Target?.Player;
		GridFightInstance gridFightInstance = playerInstance?.GridFightManager?.GridFightInstance;
		if (playerInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (gridFightInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.NotInGame"));
			return;
		}
		if (arg.BasicArgs.Count < 1)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		uint consumableId = (uint)arg.GetInt(0);
		if (!GameData.GridFightConsumablesData.ContainsKey(consumableId))
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.InvalidConsumable"));
			return;
		}
		GridFightConsumableInfo gridFightConsumableInfo = gridFightInstance.Consumables.FirstOrDefault((GridFightConsumableInfo x) => x.ItemId == consumableId);
		if (gridFightConsumableInfo == null)
		{
			gridFightConsumableInfo = new GridFightConsumableInfo
			{
				ItemId = consumableId,
				Num = 1u
			};
			gridFightInstance.Consumables.Add(gridFightConsumableInfo);
		}
		else
		{
			gridFightConsumableInfo.Num++;
		}
		GridFightGameItemSyncInfo gridFightGameItemSyncInfo = new GridFightGameItemSyncInfo();
		gridFightGameItemSyncInfo.GridFightConsumableList.Add(gridFightConsumableInfo.Clone());
		GridFightSyncUpdateResultScNotify gridFightSyncUpdateResultScNotify = new GridFightSyncUpdateResultScNotify();
		GridFightSyncResultData gridFightSyncResultData = new GridFightSyncResultData();
		gridFightSyncResultData.UpdateDynamicList.Add(new GridFightSyncData
		{
			AddGameItemInfo = gridFightGameItemSyncInfo
		});
		gridFightSyncUpdateResultScNotify.SyncResultDataList.Add(gridFightSyncResultData);
		await playerInstance.SendPacket(new PacketGridFightSyncUpdateResultScNotify(gridFightSyncUpdateResultScNotify));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.AddConsumable", consumableId.ToString()));
	}

	[CommandMethod("0 section")]
	public async ValueTask SetSection(CommandArg arg)
	{
		PlayerInstance? obj = arg.Target?.Player;
		GridFightInstance gridFightInstance = obj?.GridFightManager?.GridFightInstance;
		if (obj == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.PlayerNotFound"));
			return;
		}
		if (gridFightInstance == null)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.NotInGame"));
			return;
		}
		if (arg.BasicArgs.Count < 2)
		{
			await arg.SendMsg(I18NManager.Translate("Game.Command.Notice.InvalidArguments"));
			return;
		}
		uint currentChapterId = (uint)Math.Max(1, arg.GetInt(0));
		uint sectionId = (uint)Math.Max(1, arg.GetInt(1));
		gridFightInstance.CurrentChapterId = currentChapterId;
		gridFightInstance.SectionId = sectionId;
		GridFightLevelEncounter gridFightLevelEncounter = GridFightLevelResolver.Resolve(gridFightInstance);
		gridFightInstance.ConfigureNextBattle(gridFightLevelEncounter.StageId, gridFightLevelEncounter.Monsters.Select((GridFightMonsterSpec m) => m.MonsterId));
		await arg.SendMsg(I18NManager.Translate("Game.Command.Grid.EnterSection", currentChapterId.ToString(), sectionId.ToString()));
	}
}
