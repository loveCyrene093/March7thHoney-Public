using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Quests;
using March7thHoney.Enums.Mission;
using March7thHoney.Enums.Quest;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.PlayerSync;
using March7thHoney.Proto;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Quest;

public class QuestManager(PlayerInstance player) : BasePlayerManager(player)
{
	public UnlockHandler UnlockHandler { get; } = new UnlockHandler(player);

	public QuestData QuestData { get; } = DatabaseHelper.Instance.GetInstanceOrCreateNew<QuestData>(player.Uid);

	public List<QuestInfo> WaitToSync { get; } = new List<QuestInfo>();

	public void OnBattleStart(BattleInstance instance)
	{
		foreach (QuestInfo item in GetRunningQuest())
		{
			QuestDataExcel valueOrDefault = GameData.QuestDataData.GetValueOrDefault(item.QuestId);
			if (valueOrDefault == null)
			{
				continue;
			}
			FinishWayExcel valueOrDefault2 = GameData.FinishWayData.GetValueOrDefault(valueOrDefault.FinishWayID);
			if (valueOrDefault2 == null || valueOrDefault2.FinishType != MissionFinishTypeEnum.BattleChallenge)
			{
				continue;
			}
			foreach (int paramInt in valueOrDefault2.ParamIntList)
			{
				instance.AddBattleTarget(2, paramInt, GetQuestProgress(valueOrDefault.QuestID), valueOrDefault2.Progress);
			}
		}
	}

	public async ValueTask AcceptQuestByCondition()
	{
		if (!ConfigManager.Config.ServerOption.EnableQuest)
		{
			return;
		}
		List<QuestInfo> syncList = new List<QuestInfo>();
		foreach (QuestDataExcel value in GameData.QuestDataData.Values)
		{
			if (QuestData.Quests.ContainsKey(value.QuestID))
			{
				continue;
			}
			QuestInfo questInfo = null;
			switch (value.UnlockType)
			{
			case QuestUnlockTypeEnum.AutoUnlock:
				questInfo = await AcceptQuest(value.QuestID, sync: false);
				break;
			case QuestUnlockTypeEnum.FinishMission:
			{
				bool flag2 = true;
				foreach (int unlockParam in value.UnlockParamList)
				{
					if (base.Player.MissionManager.GetMainMissionStatus(unlockParam) != MissionPhaseEnum.Finish)
					{
						flag2 = false;
						break;
					}
				}
				if (flag2)
				{
					questInfo = await AcceptQuest(value.QuestID, sync: false);
				}
				break;
			}
			case QuestUnlockTypeEnum.FinishQuest:
			{
				bool flag = true;
				foreach (int unlockParam2 in value.UnlockParamList)
				{
					if (GetQuestStatus(unlockParam2) != QuestStatus.QuestFinish && GetQuestStatus(unlockParam2) != QuestStatus.QuestClose)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					questInfo = await AcceptQuest(value.QuestID, sync: false);
				}
				break;
			}
			}
			if (questInfo != null)
			{
				syncList.Add(questInfo);
			}
		}
		if (syncList.Count > 0)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(syncList));
		}
	}

	public async ValueTask<QuestInfo?> AcceptQuest(int questId, bool sync = true)
	{
		if (!ConfigManager.Config.ServerOption.EnableQuest)
		{
			return null;
		}
		GameData.QuestDataData.TryGetValue(questId, out QuestDataExcel value);
		if (value == null)
		{
			return null;
		}
		if (QuestData.Quests.ContainsKey(questId))
		{
			return null;
		}
		QuestInfo questInfo = new QuestInfo
		{
			QuestId = questId,
			QuestStatus = QuestStatus.QuestDoing,
			Progress = 0
		};
		QuestData.Quests.Add(questId, questInfo);
		if (sync)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(questInfo));
		}
		return questInfo;
	}

	public async ValueTask FinishQuest(int questId, bool push = true)
	{
		if (!ConfigManager.Config.ServerOption.EnableQuest)
		{
			return;
		}
		GameData.QuestDataData.TryGetValue(questId, out QuestDataExcel value);
		if (value == null)
		{
			return;
		}
		GameData.FinishWayData.TryGetValue(value.FinishWayID, out FinishWayExcel value2);
		if (value2 != null && QuestData.Quests.TryGetValue(questId, out QuestInfo value3) && value3.QuestStatus == QuestStatus.QuestDoing)
		{
			value3.QuestStatus = QuestStatus.QuestFinish;
			value3.Progress = value2.Progress;
			value3.FinishTime = DateTime.Now.ToUnixSec();
			if (push)
			{
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(value3));
			}
			else
			{
				WaitToSync.SafeAdd(value3);
			}
			await AcceptQuestByCondition();
		}
	}

	public async ValueTask<Retcode> FinishQuestByClient(int questId)
	{
		if (!ConfigManager.Config.ServerOption.EnableQuest)
		{
			return Retcode.RetSucc;
		}
		GameData.QuestDataData.TryGetValue(questId, out QuestDataExcel value);
		if (value == null)
		{
			return Retcode.RetFail;
		}
		GameData.FinishWayData.TryGetValue(value.FinishWayID, out FinishWayExcel value2);
		if (value2 == null)
		{
			return Retcode.RetQuestStatusError;
		}
		if (value2.FinishType != MissionFinishTypeEnum.AutoFinish && value2.FinishType != MissionFinishTypeEnum.TimeLineSetStateCnt && value2.FinishType != MissionFinishTypeEnum.FinishQuestByClient)
		{
			return Retcode.RetQuestStatusError;
		}
		if (!QuestData.Quests.TryGetValue(questId, out QuestInfo value3))
		{
			return Retcode.RetQuestNotAccept;
		}
		if (value3.QuestStatus != QuestStatus.QuestDoing)
		{
			return Retcode.RetQuestStatusError;
		}
		value3.QuestStatus = QuestStatus.QuestFinish;
		value3.Progress = value2.Progress;
		value3.FinishTime = DateTime.Now.ToUnixSec();
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(value3));
		await AcceptQuestByCondition();
		return Retcode.RetSucc;
	}

	public async ValueTask<(Retcode, List<ItemData>?)> TakeQuestReward(int questId)
	{
		GameData.QuestDataData.TryGetValue(questId, out QuestDataExcel value);
		if (value == null)
		{
			return (Retcode.RetFail, null);
		}
		if (!QuestData.Quests.TryGetValue(questId, out QuestInfo questInfo))
		{
			return (Retcode.RetQuestNotAccept, null);
		}
		if (questInfo.QuestStatus != QuestStatus.QuestFinish)
		{
			return (Retcode.RetQuestNotFinish, null);
		}
		questInfo.QuestStatus = QuestStatus.QuestClose;
		List<ItemData> items = await base.Player.InventoryManager.HandleReward(value.RewardID);
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(questInfo));
		return (Retcode.RetSucc, items);
	}

	public async ValueTask<(Retcode, List<ItemData>)> TakeQuestOptionalReward(int questId, int optionalRewardId)
	{
		List<ItemData> rewards = new List<ItemData>();
		GameData.QuestDataData.TryGetValue(questId, out QuestDataExcel value);
		if (value == null)
		{
			return (Retcode.RetFail, rewards);
		}
		if (!QuestData.Quests.TryGetValue(questId, out QuestInfo questInfo))
		{
			return (Retcode.RetQuestNotAccept, rewards);
		}
		if (questInfo.QuestStatus != QuestStatus.QuestFinish)
		{
			return (Retcode.RetQuestNotFinish, rewards);
		}
		questInfo.QuestStatus = QuestStatus.QuestClose;
		if (value.RewardID != 0)
		{
			await AppendGrantedRewardForRsp(value.RewardID, rewards);
		}
		if (optionalRewardId != 0)
		{
			if (GameData.RewardDataData.ContainsKey(optionalRewardId))
			{
				await AppendGrantedRewardForRsp(optionalRewardId, rewards);
			}
			else
			{
				ItemData itemData = await base.Player.InventoryManager.AddItem(optionalRewardId, 1, notify: false);
				if (itemData != null)
				{
					rewards.Add(itemData);
				}
			}
		}
		await base.Player.SendPacket(new PacketPlayerSyncScNotify(questInfo));
		return (Retcode.RetSucc, rewards);
	}

	private async ValueTask AppendGrantedRewardForRsp(int rewardId, List<ItemData> rewards)
	{
		List<ItemData> list = await base.Player.InventoryManager.HandleReward(rewardId);
		if (list.Count > 0)
		{
			rewards.AddRange(list);
		}
		else
		{
			if (!GameData.RewardDataData.TryGetValue(rewardId, out RewardDataExcel value) || value == null)
			{
				return;
			}
			foreach (var (num, num2) in value.GetItems())
			{
				if (num > 0 && num2 > 0)
				{
					rewards.Add(new ItemData
					{
						ItemId = num,
						Count = num2
					});
				}
			}
			if (value.Hcoin > 0)
			{
				rewards.Add(new ItemData
				{
					ItemId = 1,
					Count = value.Hcoin
				});
			}
		}
	}

	public async ValueTask AddQuestProgress(int questId, int progress, bool push = false)
	{
		GameData.QuestDataData.TryGetValue(questId, out QuestDataExcel value);
		if (value == null)
		{
			return;
		}
		GameData.FinishWayData.TryGetValue(value.FinishWayID, out FinishWayExcel value2);
		if (value2 != null && QuestData.Quests.TryGetValue(questId, out QuestInfo value3) && value3.QuestStatus == QuestStatus.QuestDoing)
		{
			value3.Progress += progress;
			if (value3.Progress >= value2.Progress)
			{
				await FinishQuest(questId, push);
			}
			else if (push)
			{
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(value3));
			}
			else
			{
				WaitToSync.SafeAdd(value3);
			}
		}
	}

	public async ValueTask UpdateQuestProgress(int questId, int progress, bool push = false)
	{
		GameData.QuestDataData.TryGetValue(questId, out QuestDataExcel value);
		if (value == null)
		{
			return;
		}
		GameData.FinishWayData.TryGetValue(value.FinishWayID, out FinishWayExcel value2);
		if (value2 != null && QuestData.Quests.TryGetValue(questId, out QuestInfo value3) && value3.QuestStatus == QuestStatus.QuestDoing && progress >= value3.Progress && progress != value3.Progress)
		{
			value3.Progress = progress;
			if (value3.Progress >= value2.Progress)
			{
				await FinishQuest(questId, push);
			}
			else if (push)
			{
				await base.Player.SendPacket(new PacketPlayerSyncScNotify(value3));
			}
			else
			{
				WaitToSync.SafeAdd(value3);
			}
		}
	}

	public async ValueTask SyncQuest()
	{
		if (WaitToSync.Count != 0)
		{
			await base.Player.SendPacket(new PacketPlayerSyncScNotify(WaitToSync));
			WaitToSync.Clear();
		}
	}

	public QuestStatus GetQuestStatus(int questId)
	{
		if (!ConfigManager.Config.ServerOption.EnableQuest)
		{
			return QuestStatus.QuestFinish;
		}
		if (!QuestData.Quests.TryGetValue(questId, out QuestInfo value))
		{
			return QuestStatus.QuestNone;
		}
		return value.QuestStatus;
	}

	public List<QuestInfo> GetRunningQuest()
	{
		if (!ConfigManager.Config.ServerOption.EnableQuest)
		{
			return new List<QuestInfo>();
		}
		return QuestData.Quests.Values.Where((QuestInfo x) => x.QuestStatus == QuestStatus.QuestDoing).ToList();
	}

	public int GetQuestProgress(int questId)
	{
		if (!QuestData.Quests.TryGetValue(questId, out QuestInfo value))
		{
			return 0;
		}
		return value.Progress;
	}
}
