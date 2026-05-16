using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Config;
using March7thHoney.Data.Config.Scene;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.Database.Quests;
using March7thHoney.Enums.Item;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Mission.FinishAction;
using March7thHoney.GameServer.Game.Mission.FinishType;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Plugin.Event;
using March7thHoney.GameServer.Server.Packet.Send.HeartDial;
using March7thHoney.GameServer.Server.Packet.Send.Mission;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Mission;

public class MissionManager : BasePlayerManager
{
	public static readonly Dictionary<FinishActionTypeEnum, MissionFinishActionHandler> ActionHandlers = new Dictionary<FinishActionTypeEnum, MissionFinishActionHandler>();

	public static readonly Dictionary<MissionFinishTypeEnum, MissionFinishTypeHandler> FinishTypeHandlers = new Dictionary<MissionFinishTypeEnum, MissionFinishTypeHandler>();

	public readonly List<int> SkipSubMissionList;

	public MissionData Data { get; set; }

	public MissionManager(PlayerInstance player)
	{
		Data = DatabaseHelper.Instance.GetInstanceOrCreateNew<MissionData>(player.Uid);
		SkipSubMissionList = new List<int>();
		base._002Ector(player);
	}

	public List<int> GetAllFinishedMissionIds()
	{
		return (from x in (from x in Data.FinishedSubMissionIds.Concat(Data.FinishedMainMissionIds)
				where x > 0
				select x).Distinct()
			orderby x
			select x).ToList();
	}

	public async ValueTask<List<MissionSync?>> AcceptMainMission(int missionId, bool sendPacket = true)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return new List<MissionSync>();
		}
		if (Data.GetMainMissionStatus(missionId) != MissionPhaseEnum.None)
		{
			return new List<MissionSync>();
		}
		GameData.MainMissionData.TryGetValue(missionId, out MainMissionExcel mission);
		if (mission == null)
		{
			return new List<MissionSync>();
		}
		Data.SetMainMissionStatus(missionId, MissionPhaseEnum.Accept);
		List<MissionSync?> list = new List<MissionSync>();
		mission.MissionInfo?.StartSubMissionList.ForEach(async delegate(int i)
		{
			List<MissionSync?> list2 = list;
			list2.Add(await AcceptSubMission(i, sendPacket));
		});
		if (missionId == 4030001 || missionId == 4030002)
		{
			mission.MissionInfo?.SubMissionList.ForEach(async delegate(SubMissionInfo x)
			{
				await AcceptSubMission(x.ID);
			});
			mission.MissionInfo?.SubMissionList.ForEach(async delegate(SubMissionInfo x)
			{
				await FinishSubMission(x.ID);
			});
		}
		if (missionId == 1000400)
		{
			await base.Player.AddAvatar(1003);
			await base.Player.LineupManager.AddAvatarToCurTeam(1003);
		}
		foreach (MessageSectionConfigExcel item in GameData.MessageSectionConfigData.Values.Where((MessageSectionConfigExcel x) => x.MainMissionLink == missionId))
		{
			await base.Player.MessageManager.AddMessageSection(item.ID);
		}
		foreach (SubMissionInfo item2 in mission.MissionInfo.SubMissionList.Where(delegate(SubMissionInfo x)
		{
			MissionFinishTypeEnum finishType = x.FinishType;
			return (finishType == MissionFinishTypeEnum.MessageSectionFinish || finishType == MissionFinishTypeEnum.MessagePerformSectionFinish) ? true : false;
		}))
		{
			await base.Player.MessageManager.AddMessageSection(item2.ParamInt1);
		}
		return list;
	}

	public async ValueTask<MissionSync> AcceptMainMissionByCondition(bool sendPacket = true)
	{
		MissionSync sync = new MissionSync();
		foreach (MainMissionExcel value in GameData.MainMissionData.Values)
		{
			if (!value.IsEqual(Data) || Data.GetMainMissionStatus(value.MainMissionID) != MissionPhaseEnum.None)
			{
				continue;
			}
			foreach (MissionSync item in await AcceptMainMission(value.MainMissionID, sendPacket))
			{
				if (item != null)
				{
					sync.MissionList.AddRange(item.MissionList);
				}
			}
		}
		return sync;
	}

	public async ValueTask<List<MissionSync?>> ReAcceptMainMission(int missionId, bool sendPacket = true)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return new List<MissionSync>();
		}
		GameData.MainMissionData.TryGetValue(missionId, out MainMissionExcel value);
		if (value == null)
		{
			return new List<MissionSync>();
		}
		MissionSync missionSync = new MissionSync();
		foreach (int subMissionId in value.SubMissionIds)
		{
			if (Data.GetSubMissionStatus(subMissionId) == MissionPhaseEnum.Finish || Data.GetSubMissionStatus(subMissionId) == MissionPhaseEnum.Accept)
			{
				missionSync.MissionList.Add(new March7thHoney.Proto.Mission
				{
					Id = (uint)subMissionId,
					Status = MissionStatus.MissionNone
				});
			}
		}
		foreach (int subMissionId2 in value.SubMissionIds)
		{
			Data.SetSubMissionStatus(subMissionId2, MissionPhaseEnum.None);
		}
		Data.SetMainMissionStatus(missionId, MissionPhaseEnum.None);
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(missionSync));
		return await AcceptMainMission(missionId, sendPacket);
	}

	public async ValueTask RemoveMainMission(int missionId)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return;
		}
		Data.SetMainMissionStatus(missionId, MissionPhaseEnum.None);
		GameData.MainMissionData.TryGetValue(missionId, out MainMissionExcel value);
		if (value == null)
		{
			return;
		}
		MissionSync sync = new MissionSync();
		foreach (int subMission in value.SubMissionIds)
		{
			Data.SetSubMissionStatus(subMission, MissionPhaseEnum.None);
			await SetMissionProgress(subMission, 0, sendPacket: false);
			sync.MissionList.Add(new March7thHoney.Proto.Mission
			{
				Id = (uint)subMission,
				Status = MissionStatus.MissionNone
			});
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(sync));
	}

	public async ValueTask AcceptSubMission(int missionId)
	{
		if (ConfigManager.Config.ServerOption.EnableMission)
		{
			await AcceptSubMission(missionId, sendPacket: true);
		}
	}

	public async ValueTask<MissionSync?> AcceptSubMission(int missionId, bool sendPacket, bool doFinishTypeAction = true)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return null;
		}
		GameData.SubMissionInfoData.TryGetValue(missionId, out SubMissionData mission);
		if (mission == null)
		{
			return null;
		}
		if (Data.GetSubMissionStatus(missionId) != MissionPhaseEnum.None)
		{
			return null;
		}
		Data.SetSubMissionStatus(missionId, MissionPhaseEnum.Accept);
		MissionSync sync = new MissionSync
		{
			MissionList = 
			{
				new March7thHoney.Proto.Mission
				{
					Id = (uint)missionId,
					Status = MissionStatus.MissionDoing
				}
			}
		};
		if (sendPacket)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(sync));
		}
		base.Player.SceneInstance?.SyncGroupInfo();
		if (mission.SubMissionInfo != null)
		{
			try
			{
				FinishTypeHandlers.TryGetValue(mission.SubMissionInfo.FinishType, out MissionFinishTypeHandler value);
				if (doFinishTypeAction && value != null)
				{
					await value.HandleMissionFinishType(base.Player, mission.SubMissionInfo, null);
				}
			}
			catch
			{
			}
		}
		if (SkipSubMissionList.Contains(missionId))
		{
			await FinishSubMission(missionId);
		}
		if (mission.SubMissionInfo?.LevelFloorID == base.Player.SceneInstance?.FloorId && mission.SubMissionInfo?.GroupIDList != null)
		{
			foreach (int groupID in mission.SubMissionInfo.GroupIDList)
			{
				await base.Player.SceneInstance.EntityLoader.LoadGroup(groupID);
			}
		}
		base.Player.TaskManager?.MissionTaskTrigger.TriggerMissionTask(missionId);
		return sync;
	}

	public async ValueTask FinishMainMission(int missionId)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission || !GameData.MainMissionData.TryGetValue(missionId, out MainMissionExcel value) || Data.GetMainMissionStatus(missionId) != MissionPhaseEnum.Accept)
		{
			return;
		}
		Data.SetMainMissionStatus(missionId, MissionPhaseEnum.Finish);
		List<int> finishedMissionIds = new List<int> { missionId };
		MissionSync sync = new MissionSync
		{
			FinishedMainMissionIdList = { (uint)missionId }
		};
		foreach (int subMissionId in value.SubMissionIds)
		{
			if (GetSubMissionStatus(subMissionId) != MissionPhaseEnum.Finish && Data.GetSubMissionStatus(subMissionId) != MissionPhaseEnum.Finish)
			{
				Data.SetSubMissionStatus(subMissionId, MissionPhaseEnum.Finish);
				finishedMissionIds.Add(subMissionId);
				sync.MissionList.Add(new March7thHoney.Proto.Mission
				{
					Id = (uint)subMissionId,
					Status = MissionStatus.MissionFinish
				});
			}
		}
		MissionSync missionSync = await AcceptMainMissionByCondition(sendPacket: false);
		sync.MissionList.AddRange(missionSync.MissionList);
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(sync));
		await base.Player.SendPacket(new PacketStartFinishMainMissionScNotify(missionId));
		await base.Player.SendPacket(new PacketFinishedMissionScNotify(finishedMissionIds));
		await HandleMissionReward(missionId);
		await HandleFinishType(MissionFinishTypeEnum.FinishMission);
		await base.Player.RaidManager.CheckIfLeaveRaid();
		PluginEvent.InvokeOnPlayerFinishMainMission(base.Player, missionId);
	}

	public async ValueTask FinishSubMission(int missionId)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return;
		}
		GameData.SubMissionInfoData.TryGetValue(missionId, out SubMissionData subMission);
		if (subMission == null)
		{
			return;
		}
		int mainMissionId = subMission.MainMissionId;
		if (Data.GetSubMissionStatus(missionId) != MissionPhaseEnum.Accept)
		{
			return;
		}
		GameData.MainMissionData.TryGetValue(mainMissionId, out MainMissionExcel mainMission);
		if (mainMission == null)
		{
			return;
		}
		Data.SetSubMissionStatus(missionId, MissionPhaseEnum.Finish);
		await SetMissionProgress(missionId, subMission.SubMissionInfo?.Progress ?? 1);
		MissionSync sync = new MissionSync
		{
			MissionList = 
			{
				new March7thHoney.Proto.Mission
				{
					Id = (uint)missionId,
					Status = MissionStatus.MissionFinish,
					Progress = (uint)(subMission.SubMissionInfo?.Progress ?? 1)
				}
			}
		};
		foreach (SubMissionInfo nextMission in mainMission.MissionInfo?.SubMissionList ?? new List<SubMissionInfo>())
		{
			if (nextMission.TakeType != SubMissionTakeTypeEnum.AnySequence && nextMission.TakeType != SubMissionTakeTypeEnum.MultiSequence)
			{
				continue;
			}
			bool flag = nextMission.TakeType == SubMissionTakeTypeEnum.MultiSequence;
			foreach (int item in nextMission.TakeParamIntList ?? new List<int>())
			{
				if (GetSubMissionStatus(item) != MissionPhaseEnum.Finish && nextMission.TakeType == SubMissionTakeTypeEnum.MultiSequence)
				{
					flag = false;
					break;
				}
				if (GetSubMissionStatus(item) == MissionPhaseEnum.Finish && nextMission.TakeType == SubMissionTakeTypeEnum.AnySequence)
				{
					flag = true;
					break;
				}
			}
			if (flag && await AcceptSubMission(nextMission.ID, sendPacket: false, doFinishTypeAction: false) != null)
			{
				sync.MissionList.Add(new March7thHoney.Proto.Mission
				{
					Id = (uint)nextMission.ID,
					Status = MissionStatus.MissionDoing
				});
			}
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(sync));
		await base.Player.SendPacket(new PacketStartFinishSubMissionScNotify(missionId));
		await base.Player.SendPacket(new PacketFinishedMissionScNotify(missionId));
		if (mainMission.MissionInfo != null)
		{
			await HandleFinishAction(mainMission.MissionInfo, missionId);
		}
		bool shouldFinish = true;
		mainMission.MissionInfo?.FinishSubMissionList.ForEach(delegate(int id)
		{
			if (GetSubMissionStatus(id) != MissionPhaseEnum.Finish)
			{
				shouldFinish = false;
			}
		});
		foreach (SubMissionInfo runningSubMission in GetRunningSubMissionList())
		{
			FinishTypeHandlers.TryGetValue(runningSubMission.FinishType, out MissionFinishTypeHandler value);
			if (value != null)
			{
				await value.HandleMissionFinishType(base.Player, runningSubMission, null);
			}
		}
		if (shouldFinish)
		{
			await FinishMainMission(mainMissionId);
		}
		if (missionId == 101140201)
		{
			List<int> list = base.Player.LineupManager.GetCurLineup().BaseAvatars.Select((LineupAvatarInfo x) => (x.SpecialAvatarId <= 0) ? x.BaseAvatarId : x.SpecialAvatarId).ToList();
			list[list.IndexOf(8001)] = ((base.Player.Data.CurrentGender == Gender.Man) ? 1008003 : 1008004);
			base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupHeliobus, list);
		}
		if (missionId == 103040103)
		{
			await base.Player.SendPacket(new PacketHeartDialScriptChangeScNotify(HeartDialUnlockStatus.UnlockSingle));
		}
		if (missionId == 103040104)
		{
			await base.Player.SendPacket(new PacketHeartDialScriptChangeScNotify(HeartDialUnlockStatus.UnlockAll));
		}
		await HandleSubMissionReward(missionId);
		PluginEvent.InvokeOnPlayerFinishSubMission(base.Player, missionId);
	}

	public async ValueTask HandleFinishAction(March7thHoney.Data.Config.MissionInfo info, int subMissionId)
	{
		SubMissionInfo subMissionInfo = info.SubMissionList.Find((SubMissionInfo x) => x.ID == subMissionId);
		if (subMissionInfo == null)
		{
			return;
		}
		foreach (FinishActionInfo item in subMissionInfo.FinishActionList ?? new List<FinishActionInfo>())
		{
			await HandleFinishAction(item);
		}
	}

	public async ValueTask HandleFinishAction(FinishActionInfo actionInfo)
	{
		ActionHandlers.TryGetValue(actionInfo.FinishActionType, out MissionFinishActionHandler value);
		if (value != null)
		{
			await value.OnHandle(actionInfo.FinishActionPara, actionInfo.FinishActionParaString, base.Player);
		}
	}

	public async ValueTask HandleMissionReward(int mainMissionId)
	{
		GameData.MainMissionData.TryGetValue(mainMissionId, out MainMissionExcel mainMission);
		if (mainMission == null)
		{
			return;
		}
		GameData.RewardDataData.TryGetValue(mainMission.RewardID, out RewardDataExcel reward);
		List<ItemData> itemList = new List<ItemData>();
		foreach (var item in reward?.GetItems() ?? new List<(int, int)>())
		{
			GameData.ItemConfigData.TryGetValue(item.Item1, out ItemConfigExcel value);
			ItemData itemData = await base.Player.InventoryManager.AddItem(item.Item1, item.Item2, value != null && value.ItemMainType == ItemMainTypeEnum.AvatarCard);
			if (itemData != null)
			{
				itemList.Add(itemData);
			}
		}
		ItemData itemData2 = await base.Player.InventoryManager.AddItem(1, reward?.Hcoin ?? 0, notify: false);
		if (itemData2 != null)
		{
			itemList.Add(itemData2);
		}
		foreach (int subReward in mainMission.SubRewardList)
		{
			GameData.RewardDataData.TryGetValue(subReward, out RewardDataExcel rewardDataExcel);
			ItemData itemData3 = await base.Player.InventoryManager.AddItem(1, rewardDataExcel?.Hcoin ?? 0, notify: false);
			if (itemData3 != null)
			{
				itemList.Add(itemData3);
			}
			foreach (var item2 in rewardDataExcel?.GetItems() ?? new List<(int, int)>())
			{
				GameData.ItemConfigData.TryGetValue(item2.Item1, out ItemConfigExcel value2);
				ItemData itemData4 = await base.Player.InventoryManager.AddItem(item2.Item1, item2.Item2, value2 != null && value2.ItemMainType == ItemMainTypeEnum.AvatarCard);
				if (itemData4 != null)
				{
					itemList.Add(itemData4);
				}
			}
			rewardDataExcel = null;
		}
		if (itemList.Count > 0)
		{
			await base.Player.SendPacket(new PacketMissionRewardScNotify(mainMissionId, 0, itemList));
		}
	}

	public async ValueTask HandleSubMissionReward(int subMissionId)
	{
		GameData.SubMissionInfoData.TryGetValue(subMissionId, out SubMissionData value);
		if (value == null)
		{
			return;
		}
		GameData.RewardDataData.TryGetValue(value.SubMissionInfo?.SubRewardID ?? 0, out RewardDataExcel value2);
		List<ItemData> itemList = new List<ItemData>();
		foreach (var item in value2?.GetItems() ?? new List<(int, int)>())
		{
			GameData.ItemConfigData.TryGetValue(item.Item1, out ItemConfigExcel value3);
			ItemData itemData = await base.Player.InventoryManager.AddItem(item.Item1, item.Item2, value3 != null && value3.ItemMainType == ItemMainTypeEnum.AvatarCard);
			if (itemData != null)
			{
				itemList.Add(itemData);
			}
		}
		await base.Player.SendPacket(new PacketSubMissionRewardScNotify(subMissionId, itemList));
	}

	public async ValueTask HandleFinishType(MissionFinishTypeEnum finishType, object? arg = null, bool pushQuest = true)
	{
		FinishTypeHandlers.TryGetValue(finishType, out MissionFinishTypeHandler handler);
		foreach (SubMissionInfo runningSubMission in GetRunningSubMissionList())
		{
			if (runningSubMission.FinishType == finishType && handler != null)
			{
				await handler.HandleMissionFinishType(base.Player, runningSubMission, arg);
			}
		}
		foreach (QuestInfo item in base.Player.QuestManager?.GetRunningQuest() ?? new List<QuestInfo>())
		{
			QuestDataExcel valueOrDefault = GameData.QuestDataData.GetValueOrDefault(item.QuestId);
			if (valueOrDefault != null)
			{
				FinishWayExcel valueOrDefault2 = GameData.FinishWayData.GetValueOrDefault(valueOrDefault.FinishWayID);
				if (valueOrDefault2 != null && valueOrDefault2.FinishType == finishType && handler != null)
				{
					await handler.HandleQuestFinishType(base.Player, valueOrDefault, valueOrDefault2, arg);
				}
			}
		}
		if (pushQuest)
		{
			await base.Player.QuestManager.SyncQuest();
		}
	}

	public async ValueTask HandleAllFinishType(object? arg = null)
	{
		foreach (KeyValuePair<MissionFinishTypeEnum, MissionFinishTypeHandler> finishTypeHandler in FinishTypeHandlers)
		{
			await HandleFinishType(finishTypeHandler.Key, arg, pushQuest: false);
		}
		await base.Player.QuestManager.SyncQuest();
	}

	public async ValueTask HandleTalkStr(string talkString)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return;
		}
		foreach (SubMissionInfo runningSubMission in GetRunningSubMissionList())
		{
			if (runningSubMission.FinishType == MissionFinishTypeEnum.Talk && runningSubMission.ParamStr1 == talkString)
			{
				await FinishSubMission(runningSubMission.ID);
			}
		}
		foreach (QuestInfo item in base.Player.QuestManager?.GetRunningQuest() ?? new List<QuestInfo>())
		{
			QuestDataExcel valueOrDefault = GameData.QuestDataData.GetValueOrDefault(item.QuestId);
			if (valueOrDefault != null)
			{
				FinishWayExcel valueOrDefault2 = GameData.FinishWayData.GetValueOrDefault(valueOrDefault.FinishWayID);
				if (valueOrDefault2 != null && valueOrDefault2.FinishType == MissionFinishTypeEnum.Talk && valueOrDefault2.ParamStr1 == talkString)
				{
					await base.Player.QuestManager.FinishQuest(item.QuestId);
				}
			}
		}
	}

	public async ValueTask HandleCustomValue(List<MissionCustomValue> values, int missionId)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return;
		}
		GameData.SubMissionInfoData.TryGetValue(missionId, out SubMissionData value);
		if (value == null)
		{
			return;
		}
		int mainMissionId = value.MainMissionId;
		GameData.MainMissionData.TryGetValue(mainMissionId, out MainMissionExcel value2);
		if (value2 == null)
		{
			return;
		}
		foreach (SubMissionInfo item in value2.MissionInfo?.SubMissionList ?? new List<SubMissionInfo>())
		{
			if (item.TakeType != SubMissionTakeTypeEnum.CustomValue)
			{
				continue;
			}
			int index = 0;
			bool flag = false;
			List<List<int>> list = new List<List<int>>(1) { item.TakeParamIntList ?? new List<int>() };
			List<int>? takeParamIntList = item.TakeParamIntList;
			if (takeParamIntList != null && takeParamIntList.Count > 5)
			{
				int num = item.TakeParamIntList.Count / 3;
				list = new List<List<int>>();
				for (int i = 0; i < num; i++)
				{
					List<int> range = item.TakeParamIntList.GetRange(i * 3, 3);
					list.Add(range);
				}
			}
			foreach (List<int> item2 in list)
			{
				bool flag2 = true;
				foreach (int item3 in item2)
				{
					if (item3 == 0 && index == 0)
					{
						continue;
					}
					MissionCustomValue missionCustomValue = values.Find((MissionCustomValue x) => x.Index == index);
					if (missionCustomValue != null)
					{
						if (missionCustomValue.CustomValue != item3)
						{
							flag2 = false;
							break;
						}
						index++;
					}
				}
				if (flag2)
				{
					flag = true;
				}
			}
			if (flag)
			{
				await AcceptSubMission(item.ID);
			}
		}
	}

	public async ValueTask AddMissionProgress(int missionId, int progress)
	{
		if (ConfigManager.Config.ServerOption.EnableMission)
		{
			Data.SubMissionProgressDict.TryGetValue(missionId, out var value);
			Data.SubMissionProgressDict[missionId] = value + progress;
			GameData.SubMissionInfoData.TryGetValue(missionId, out SubMissionData value2);
			if (value2 != null && value + progress < (value2.SubMissionInfo?.Progress ?? 1))
			{
				MissionSync missionSync = new MissionSync();
				missionSync.MissionList.Add(new March7thHoney.Proto.Mission
				{
					Id = (uint)missionId,
					Progress = (uint)(value + progress)
				});
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(missionSync));
			}
		}
	}

	public async ValueTask SetMissionProgress(int missionId, int progress, bool sendPacket = true)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return;
		}
		Data.SubMissionProgressDict[missionId] = progress;
		GameData.SubMissionInfoData.TryGetValue(missionId, out SubMissionData value);
		if (value != null && progress < (value.SubMissionInfo?.Progress ?? 1))
		{
			MissionSync missionSync = new MissionSync();
			missionSync.MissionList.Add(new March7thHoney.Proto.Mission
			{
				Id = (uint)missionId,
				Progress = (uint)progress
			});
			if (sendPacket)
			{
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(missionSync));
			}
		}
	}

	public MissionPhaseEnum GetMainMissionStatus(int missionId)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return MissionPhaseEnum.Finish;
		}
		return Data.GetMainMissionStatus(missionId);
	}

	public MissionPhaseEnum GetSubMissionStatus(int missionId)
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return MissionPhaseEnum.Finish;
		}
		return Data.GetSubMissionStatus(missionId);
	}

	public SubMissionInfo? GetSubMissionInfo(int missionId)
	{
		GameData.SubMissionInfoData.TryGetValue(missionId, out SubMissionData value);
		return value?.SubMissionInfo;
	}

	public List<int> GetRunningSubMissionIdList()
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		list.AddRange(Data.RunningSubMissionIds);
		return list;
	}

	public List<SubMissionInfo> GetRunningSubMissionList()
	{
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return new List<SubMissionInfo>();
		}
		List<SubMissionInfo> list = new List<SubMissionInfo>();
		List<int> list2 = new List<int>();
		list2.AddRange(Data.RunningSubMissionIds);
		foreach (int item in list2)
		{
			GameData.SubMissionInfoData.TryGetValue(item, out SubMissionData value);
			if (value != null && value.SubMissionInfo != null)
			{
				list.Add(value.SubMissionInfo);
			}
		}
		return list;
	}

	public int GetMissionProgress(int missionId)
	{
		GameData.SubMissionInfoData.TryGetValue(missionId, out SubMissionData value);
		if (!ConfigManager.Config.ServerOption.EnableMission)
		{
			return (value?.SubMissionInfo?.Progress).GetValueOrDefault();
		}
		Data.SubMissionProgressDict.TryGetValue(missionId, out var value2);
		return value2;
	}

	public async ValueTask OnBattleFinish(BattleInstance instance, PVEBattleResultCsReq req)
	{
		foreach (int runningSubMissionId in GetRunningSubMissionIdList())
		{
			SubMissionInfo subMissionInfo = GetSubMissionInfo(runningSubMissionId);
			if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.StageWin && req.EndStatus == BattleEndStatus.BattleEndWin && req.StageId.ToString().StartsWith(subMissionInfo.ParamInt1.ToString()))
			{
				await FinishSubMission(runningSubMissionId);
				instance.EventId = 0;
			}
		}
		await HandleAllFinishType(instance);
	}

	public async ValueTask OnPlayerInteractWithProp()
	{
		foreach (int runningSubMissionId in GetRunningSubMissionIdList())
		{
			SubMissionInfo? subMissionInfo = GetSubMissionInfo(runningSubMissionId);
			if (subMissionInfo != null && subMissionInfo.FinishType == MissionFinishTypeEnum.PropState)
			{
				FinishTypeHandlers.TryGetValue(MissionFinishTypeEnum.PropState, out MissionFinishTypeHandler value);
				if (value != null)
				{
					await value.HandleMissionFinishType(base.Player, GetSubMissionInfo(runningSubMissionId), null);
				}
			}
		}
	}

	public async ValueTask OnPlayerChangeScene()
	{
		foreach (int runningSubMissionId in GetRunningSubMissionIdList())
		{
			SubMissionInfo subMissionInfo = GetSubMissionInfo(runningSubMissionId);
			if (subMissionInfo == null || subMissionInfo.LevelFloorID != base.Player.SceneInstance?.FloorId || subMissionInfo.GroupIDList == null)
			{
				continue;
			}
			foreach (int groupID in subMissionInfo.GroupIDList)
			{
				await base.Player.SceneInstance.EntityLoader.LoadGroup(groupID, sendPacket: false);
			}
		}
	}

	public void OnLoadScene(SceneInfo info)
	{
		List<int> list = base.Player.SceneInstance?.FloorInfo?.Groups.Values.SelectMany((GroupInfo x) => x.RelatedMissionId).ToList() ?? new List<int>();
		HashSet<int> hashSet = new HashSet<int>();
		foreach (MainMissionExcel value in GameData.MainMissionData.Values)
		{
			foreach (SubMissionInfo subMission in value.MissionInfo.SubMissionList)
			{
				if (list.Contains(subMission.ID))
				{
					info.SceneMissionInfo.SubMissionStatusList.Add(new March7thHoney.Proto.Mission
					{
						Id = (uint)subMission.ID,
						Status = GetSubMissionStatus(subMission.ID).ToProto(),
						Progress = (uint)GetMissionProgress(subMission.ID)
					});
					hashSet.Add(value.MainMissionID);
				}
			}
		}
		foreach (int item in hashSet)
		{
			if (GetMainMissionStatus(item) == MissionPhaseEnum.Finish)
			{
				info.SceneMissionInfo.FinishedMainMissionIdList.Add((uint)item);
			}
			else if (GetMainMissionStatus(item) == MissionPhaseEnum.Accept)
			{
				info.SceneMissionInfo.UnfinishedMainMissionIdList.Add((uint)item);
			}
		}
		int num = base.Player.SceneInstance?.FloorId ?? 0;
		if (num == 0)
		{
			return;
		}
		foreach (ContentPackageConfigExcel value2 in GameData.ContentPackageConfigData.Values)
		{
			if (value2.MainMissionIDList.Count == 0 || !value2.TouchesFloor(num))
			{
				continue;
			}
			foreach (int mainMissionID in value2.MainMissionIDList)
			{
				if (!info.SceneMissionInfo.FinishedMainMissionIdList.Contains((uint)mainMissionID) && !info.SceneMissionInfo.UnfinishedMainMissionIdList.Contains((uint)mainMissionID))
				{
					info.SceneMissionInfo.UnfinishedMainMissionIdList.Add((uint)mainMissionID);
				}
			}
		}
	}
}
