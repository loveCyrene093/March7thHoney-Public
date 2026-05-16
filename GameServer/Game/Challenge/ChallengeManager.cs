using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Google.Protobuf;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Challenge;
using March7thHoney.Database.Friend;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Challenge.Instances;
using March7thHoney.GameServer.Game.Lineup;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Plugin.Event;
using March7thHoney.GameServer.Server.Packet.Send.Challenge;
using March7thHoney.GameServer.Server.Packet.Send.Scene;
using March7thHoney.Proto;
using March7thHoney.Proto.ServerSide;

namespace March7thHoney.GameServer.Game.Challenge;

public class ChallengeManager(PlayerInstance player) : BasePlayerManager(player)
{
	public BaseChallengeInstance? ChallengeInstance { get; set; }

	public ChallengeData ChallengeData { get; } = DatabaseHelper.Instance.GetInstanceOrCreateNew<ChallengeData>(player.Uid);

	public async ValueTask StartChallenge(int challengeId, ChallengeStoryBuffInfo? storyBuffs, ChallengeBossBuffInfo? bossBuffs)
	{
		if (!GameData.ChallengeConfigData.TryGetValue(challengeId, out ChallengeConfigExcel excel))
		{
			await base.Player.SendPacket(new PacketStartChallengeScRsp(2801u));
			return;
		}
		if (excel.StageNum > 0 && !PrepareChallengeLineup(ExtraLineupType.LineupChallenge))
		{
			await base.Player.SendPacket(new PacketStartChallengeScRsp(2805u));
			return;
		}
		if (excel.StageNum >= 2 && !PrepareChallengeLineup(ExtraLineupType.LineupChallenge2))
		{
			await base.Player.SendPacket(new PacketStartChallengeScRsp(2805u));
			return;
		}
		ChallengeDataPb challengeDataPb = new ChallengeDataPb();
		BaseLegacyChallengeInstance instance;
		if (excel.IsBoss())
		{
			challengeDataPb.Boss = new ChallengeBossDataPb
			{
				ChallengeMazeId = (uint)excel.ID,
				CurStatus = 1u,
				CurrentStage = 1u,
				CurrentExtraLineup = ChallengeLineupTypePb.Challenge1
			};
			instance = new ChallengeBossInstance(base.Player, challengeDataPb);
		}
		else if (excel.IsStory())
		{
			challengeDataPb.Story = new ChallengeStoryDataPb
			{
				ChallengeMazeId = (uint)excel.ID,
				CurStatus = 1u,
				CurrentStage = 1u,
				CurrentExtraLineup = ChallengeLineupTypePb.Challenge1
			};
			instance = new ChallengeStoryInstance(base.Player, challengeDataPb);
		}
		else
		{
			challengeDataPb.Memory = new ChallengeMemoryDataPb
			{
				ChallengeMazeId = (uint)excel.ID,
				CurStatus = 1u,
				CurrentStage = 1u,
				CurrentExtraLineup = ChallengeLineupTypePb.Challenge1,
				RoundsLeft = (uint)excel.ChallengeCountDown
			};
			instance = new ChallengeMemoryInstance(base.Player, challengeDataPb);
		}
		ChallengeInstance = instance;
		await base.Player.LineupManager.SetExtraLineup((ExtraLineupType)instance.GetCurrentExtraLineupType(), notify: false);
		if (!(await TryEnterChallengeScene(excel.MapEntranceID)))
		{
			await base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupNone, notify: false);
			ChallengeInstance = null;
			await base.Player.SendPacket(new PacketStartChallengeScRsp(2801u));
			return;
		}
		if (instance is ChallengeBossInstance boss)
		{
			if (boss.Config.MazeGroupID2 != 0 && boss.Config.MazeGroupID2 != boss.Config.MazeGroupID1)
			{
				await base.Player.SceneInstance.EntityLoader.UnloadGroup(boss.Config.MazeGroupID2);
			}
			if (boss.Config.MazeGroupID1 != 0)
			{
				await base.Player.SceneInstance.EntityLoader.LoadGroup(boss.Config.MazeGroupID1);
			}
		}
		await base.Player.SendPacket(new PacketChallengeLineupNotify((ExtraLineupType)instance.GetCurrentExtraLineupType()));
		await base.Player.SceneInstance.SyncLineup();
		instance.SetStartPos(base.Player.Data.Pos);
		instance.SetStartRot(base.Player.Data.Rot);
		instance.SetSavedMp(base.Player.LineupManager.GetCurLineup().Mp);
		if (excel.IsStory() && storyBuffs != null)
		{
			instance.Data.Story.Buffs.Add(storyBuffs.BuffOne);
			instance.Data.Story.Buffs.Add(storyBuffs.BuffTwo);
		}
		if (bossBuffs != null)
		{
			instance.Data.Boss.Buffs.Add(bossBuffs.BuffOne);
			instance.Data.Boss.Buffs.Add(bossBuffs.BuffTwo);
		}
		PluginEvent.InvokeOnPlayerEnterChallenge(base.Player, instance);
		await base.Player.SendPacket(new PacketStartChallengeScRsp(base.Player, sendScene: false));
		await base.Player.SendPacket(new PacketEnterSceneByServerScNotify(base.Player.SceneInstance));
		SaveInstance(instance);
	}

	public void AddHistory(int challengeId, int stars, int score)
	{
		if (stars > 0)
		{
			if (!ChallengeData.History.ContainsKey(challengeId))
			{
				ChallengeData.History[challengeId] = new ChallengeHistoryData(base.Player.Uid, challengeId);
			}
			ChallengeHistoryData challengeHistoryData = ChallengeData.History[challengeId];
			challengeHistoryData.SetStars(stars);
			challengeHistoryData.Score = score;
		}
	}

	public async ValueTask<List<TakenChallengeRewardInfo>?> TakeRewards(int groupId)
	{
		if (!GameData.ChallengeGroupData.ContainsKey(groupId))
		{
			return null;
		}
		ChallengeGroupExcel challengeGroupExcel = GameData.ChallengeGroupData[groupId];
		if (!GameData.ChallengeRewardData.ContainsKey(challengeGroupExcel.RewardLineGroupID))
		{
			return null;
		}
		List<ChallengeRewardExcel> list = GameData.ChallengeRewardData[challengeGroupExcel.RewardLineGroupID];
		int num = 0;
		foreach (ChallengeConfigExcel value2 in GameData.ChallengeConfigData.Values)
		{
			if (value2.GroupID == groupId && ChallengeData.History.TryGetValue(value2.ID, out ChallengeHistoryData value))
			{
				value.GroupId = value2.GroupID;
				num += value.GetTotalStars();
			}
		}
		List<TakenChallengeRewardInfo> rewardInfos = new List<TakenChallengeRewardInfo>();
		List<ItemData> list2 = new List<ItemData>();
		foreach (ChallengeRewardExcel item in list)
		{
			if (num < item.StarCount)
			{
				continue;
			}
			if (!ChallengeData.TakenRewards.ContainsKey(groupId))
			{
				ChallengeData.TakenRewards[groupId] = new ChallengeGroupReward(base.Player.Uid, groupId);
			}
			ChallengeGroupReward challengeGroupReward = ChallengeData.TakenRewards[groupId];
			if (challengeGroupReward.HasTakenReward(item.StarCount) || !GameData.RewardDataData.ContainsKey(item.RewardID))
			{
				continue;
			}
			RewardDataExcel rewardDataExcel = GameData.RewardDataData[item.RewardID];
			TakenChallengeRewardInfo takenChallengeRewardInfo = new TakenChallengeRewardInfo
			{
				StarCount = (uint)item.StarCount,
				Reward = new ItemList()
			};
			if (rewardDataExcel.Hcoin > 0)
			{
				ItemData itemData = new ItemData
				{
					ItemId = 1,
					Count = rewardDataExcel.Hcoin
				};
				takenChallengeRewardInfo.Reward.ItemList_.Add(itemData.ToProto());
				list2.Add(itemData);
			}
			foreach (var item2 in rewardDataExcel.GetItems())
			{
				ItemData itemData2 = new ItemData
				{
					ItemId = item2.Item1,
					Count = item2.Item2
				};
				takenChallengeRewardInfo.Reward.ItemList_.Add(itemData2.ToProto());
				list2.Add(itemData2);
			}
			challengeGroupReward.SetTakenReward(item.StarCount);
			rewardInfos.Add(takenChallengeRewardInfo);
		}
		await base.Player.InventoryManager.AddItems(list2);
		return rewardInfos;
	}

	public void SaveInstance(BaseChallengeInstance instance)
	{
		ChallengeData.ChallengeInstance = Convert.ToBase64String(instance.Data.ToByteArray());
	}

	public void ClearInstance()
	{
		ChallengeData.ChallengeInstance = null;
		ChallengeInstance = null;
	}

	public void ResurrectInstance()
	{
		if (ChallengeData.ChallengeInstance != null)
		{
			byte[] data = Convert.FromBase64String(ChallengeData.ChallengeInstance);
			ChallengeDataPb challengeDataPb = ChallengeDataPb.Parser.ParseFrom(data);
			if (challengeDataPb != null)
			{
				ChallengeInstance = challengeDataPb.ChallengeTypeCase switch
				{
					ChallengeDataPb.ChallengeTypeOneofCase.Memory => new ChallengeMemoryInstance(base.Player, challengeDataPb), 
					ChallengeDataPb.ChallengeTypeOneofCase.Peak => null, 
					ChallengeDataPb.ChallengeTypeOneofCase.Story => new ChallengeStoryInstance(base.Player, challengeDataPb), 
					ChallengeDataPb.ChallengeTypeOneofCase.Boss => new ChallengeBossInstance(base.Player, challengeDataPb), 
					_ => null, 
				};
			}
			else
			{
				ChallengeData.ChallengeInstance = null;
			}
		}
	}

	public void SaveBattleRecord(BaseLegacyChallengeInstance inst)
	{
		ChallengeGroupStatisticsPb challengeGroupStatisticsPb2;
		int num2;
		if (!(inst is ChallengeMemoryInstance challengeMemoryInstance))
		{
			if (!(inst is ChallengeStoryInstance challengeStoryInstance))
			{
				if (!(inst is ChallengeBossInstance challengeBossInstance))
				{
					return;
				}
				base.Player.FriendRecordData.ChallengeGroupStatistics.TryAdd((uint)challengeBossInstance.Config.GroupID, new ChallengeGroupStatisticsPb
				{
					GroupId = (uint)challengeBossInstance.Config.GroupID
				});
				ChallengeGroupStatisticsPb challengeGroupStatisticsPb = base.Player.FriendRecordData.ChallengeGroupStatistics[(uint)challengeBossInstance.Config.GroupID];
				challengeGroupStatisticsPb2 = challengeGroupStatisticsPb;
				if (challengeGroupStatisticsPb2.BossGroupStatistics == null)
				{
					Dictionary<uint, BossGroupStatisticsPb> dictionary = (challengeGroupStatisticsPb2.BossGroupStatistics = new Dictionary<uint, BossGroupStatisticsPb>());
				}
				uint num = 0u;
				for (int i = 0; i < 3; i++)
				{
					num += (((challengeBossInstance.Data.Boss.Stars & (1 << i)) != 0) ? 1u : 0u);
				}
				BossGroupStatisticsPb? valueOrDefault = challengeGroupStatisticsPb.BossGroupStatistics.GetValueOrDefault((uint)challengeBossInstance.Config.ID);
				if (valueOrDefault != null && valueOrDefault.Stars > num)
				{
					return;
				}
				BossGroupStatisticsPb bossGroupStatisticsPb = new BossGroupStatisticsPb
				{
					Stars = num,
					RecordId = base.Player.FriendRecordData.NextRecordId++,
					Level = challengeBossInstance.Config.Floor,
					BuffOne = ((challengeBossInstance.Data.Boss.Buffs.Count > 0) ? challengeBossInstance.Data.Boss.Buffs[0] : 0u),
					BuffTwo = ((challengeBossInstance.Data.Boss.Buffs.Count > 1) ? challengeBossInstance.Data.Boss.Buffs[1] : 0u),
					Score = (uint)challengeBossInstance.GetTotalScore()
				};
				num2 = 1;
				List<ExtraLineupType> list = new List<ExtraLineupType>(num2);
				CollectionsMarshal.SetCount(list, num2);
				CollectionsMarshal.AsSpan(list)[0] = ExtraLineupType.LineupChallenge;
				List<ExtraLineupType> list2 = list;
				if (challengeBossInstance.Config.StageNum >= 2)
				{
					list2.Add(ExtraLineupType.LineupChallenge2);
				}
				foreach (ExtraLineupType item in list2)
				{
					March7thHoney.Database.Lineup.LineupInfo extraLineup = base.Player.LineupManager.GetExtraLineup(item);
					if (extraLineup == null)
					{
						continue;
					}
					uint num3 = 0u;
					List<ChallengeAvatarInfoPb> list3 = new List<ChallengeAvatarInfoPb>();
					foreach (LineupAvatarInfo item2 in extraLineup.BaseAvatars ?? new List<LineupAvatarInfo>())
					{
						FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar(item2.BaseAvatarId);
						if (formalAvatar != null)
						{
							list3.Add(new ChallengeAvatarInfoPb
							{
								Index = num3++,
								Id = (uint)formalAvatar.BaseAvatarId,
								AvatarType = AvatarType.AvatarFormalType,
								Level = (uint)formalAvatar.Level
							});
						}
					}
					bossGroupStatisticsPb.Lineups.Add(list3);
				}
				challengeGroupStatisticsPb.BossGroupStatistics[(uint)challengeBossInstance.Config.ID] = bossGroupStatisticsPb;
				return;
			}
			base.Player.FriendRecordData.ChallengeGroupStatistics.TryAdd((uint)challengeStoryInstance.Config.GroupID, new ChallengeGroupStatisticsPb
			{
				GroupId = (uint)challengeStoryInstance.Config.GroupID
			});
			ChallengeGroupStatisticsPb challengeGroupStatisticsPb3 = base.Player.FriendRecordData.ChallengeGroupStatistics[(uint)challengeStoryInstance.Config.GroupID];
			challengeGroupStatisticsPb2 = challengeGroupStatisticsPb3;
			if (challengeGroupStatisticsPb2.StoryGroupStatistics == null)
			{
				Dictionary<uint, StoryGroupStatisticsPb> dictionary3 = (challengeGroupStatisticsPb2.StoryGroupStatistics = new Dictionary<uint, StoryGroupStatisticsPb>());
			}
			uint num4 = 0u;
			for (int j = 0; j < 3; j++)
			{
				num4 += (((challengeStoryInstance.Data.Story.Stars & (1 << j)) != 0) ? 1u : 0u);
			}
			StoryGroupStatisticsPb? valueOrDefault2 = challengeGroupStatisticsPb3.StoryGroupStatistics.GetValueOrDefault((uint)challengeStoryInstance.Config.ID);
			if (valueOrDefault2 != null && valueOrDefault2.Stars > num4)
			{
				return;
			}
			StoryGroupStatisticsPb storyGroupStatisticsPb = new StoryGroupStatisticsPb
			{
				Stars = num4,
				RecordId = base.Player.FriendRecordData.NextRecordId++,
				Level = challengeStoryInstance.Config.Floor,
				BuffOne = ((challengeStoryInstance.Data.Story.Buffs.Count > 0) ? challengeStoryInstance.Data.Story.Buffs[0] : 0u),
				BuffTwo = ((challengeStoryInstance.Data.Story.Buffs.Count > 1) ? challengeStoryInstance.Data.Story.Buffs[1] : 0u),
				Score = (uint)challengeStoryInstance.GetTotalScore()
			};
			num2 = 1;
			List<ExtraLineupType> list4 = new List<ExtraLineupType>(num2);
			CollectionsMarshal.SetCount(list4, num2);
			CollectionsMarshal.AsSpan(list4)[0] = ExtraLineupType.LineupChallenge;
			List<ExtraLineupType> list5 = list4;
			if (challengeStoryInstance.Config.StageNum >= 2)
			{
				list5.Add(ExtraLineupType.LineupChallenge2);
			}
			foreach (ExtraLineupType item3 in list5)
			{
				March7thHoney.Database.Lineup.LineupInfo extraLineup2 = base.Player.LineupManager.GetExtraLineup(item3);
				if (extraLineup2 == null)
				{
					continue;
				}
				uint num5 = 0u;
				List<ChallengeAvatarInfoPb> list6 = new List<ChallengeAvatarInfoPb>();
				foreach (LineupAvatarInfo item4 in extraLineup2.BaseAvatars ?? new List<LineupAvatarInfo>())
				{
					FormalAvatarInfo formalAvatar2 = base.Player.AvatarManager.GetFormalAvatar(item4.BaseAvatarId);
					if (formalAvatar2 != null)
					{
						list6.Add(new ChallengeAvatarInfoPb
						{
							Index = num5++,
							Id = (uint)formalAvatar2.BaseAvatarId,
							AvatarType = AvatarType.AvatarFormalType,
							Level = (uint)formalAvatar2.Level
						});
					}
				}
				storyGroupStatisticsPb.Lineups.Add(list6);
			}
			challengeGroupStatisticsPb3.StoryGroupStatistics[(uint)challengeStoryInstance.Config.ID] = storyGroupStatisticsPb;
			return;
		}
		base.Player.FriendRecordData.ChallengeGroupStatistics.TryAdd((uint)challengeMemoryInstance.Config.GroupID, new ChallengeGroupStatisticsPb
		{
			GroupId = (uint)challengeMemoryInstance.Config.GroupID
		});
		ChallengeGroupStatisticsPb challengeGroupStatisticsPb4 = base.Player.FriendRecordData.ChallengeGroupStatistics[(uint)challengeMemoryInstance.Config.GroupID];
		challengeGroupStatisticsPb2 = challengeGroupStatisticsPb4;
		if (challengeGroupStatisticsPb2.MemoryGroupStatistics == null)
		{
			Dictionary<uint, MemoryGroupStatisticsPb> dictionary5 = (challengeGroupStatisticsPb2.MemoryGroupStatistics = new Dictionary<uint, MemoryGroupStatisticsPb>());
		}
		uint num6 = 0u;
		for (int k = 0; k < 3; k++)
		{
			num6 += (((challengeMemoryInstance.Data.Memory.Stars & (1 << k)) != 0) ? 1u : 0u);
		}
		MemoryGroupStatisticsPb? valueOrDefault3 = challengeGroupStatisticsPb4.MemoryGroupStatistics.GetValueOrDefault((uint)challengeMemoryInstance.Config.ID);
		if (valueOrDefault3 != null && valueOrDefault3.Stars > num6)
		{
			return;
		}
		MemoryGroupStatisticsPb memoryGroupStatisticsPb = new MemoryGroupStatisticsPb
		{
			RoundCount = (uint)(challengeMemoryInstance.Config.ChallengeCountDown - challengeMemoryInstance.Data.Memory.RoundsLeft),
			Stars = num6,
			RecordId = base.Player.FriendRecordData.NextRecordId++,
			Level = challengeMemoryInstance.Config.Floor
		};
		num2 = 1;
		List<ExtraLineupType> list7 = new List<ExtraLineupType>(num2);
		CollectionsMarshal.SetCount(list7, num2);
		CollectionsMarshal.AsSpan(list7)[0] = ExtraLineupType.LineupChallenge;
		List<ExtraLineupType> list8 = list7;
		if (challengeMemoryInstance.Config.StageNum >= 2)
		{
			list8.Add(ExtraLineupType.LineupChallenge2);
		}
		foreach (ExtraLineupType item5 in list8)
		{
			March7thHoney.Database.Lineup.LineupInfo extraLineup3 = base.Player.LineupManager.GetExtraLineup(item5);
			if (extraLineup3 == null)
			{
				continue;
			}
			uint num7 = 0u;
			List<ChallengeAvatarInfoPb> list9 = new List<ChallengeAvatarInfoPb>();
			foreach (LineupAvatarInfo item6 in extraLineup3.BaseAvatars ?? new List<LineupAvatarInfo>())
			{
				FormalAvatarInfo formalAvatar3 = base.Player.AvatarManager.GetFormalAvatar(item6.BaseAvatarId);
				if (formalAvatar3 != null)
				{
					list9.Add(new ChallengeAvatarInfoPb
					{
						Index = num7++,
						Id = (uint)formalAvatar3.BaseAvatarId,
						AvatarType = AvatarType.AvatarFormalType,
						Level = (uint)formalAvatar3.Level
					});
				}
			}
			memoryGroupStatisticsPb.Lineups.Add(list9);
		}
		challengeGroupStatisticsPb4.MemoryGroupStatistics[(uint)challengeMemoryInstance.Config.ID] = memoryGroupStatisticsPb;
	}

	private bool PrepareChallengeLineup(ExtraLineupType lineupType)
	{
		March7thHoney.Database.Lineup.LineupInfo extraLineup = base.Player.LineupManager.GetExtraLineup(lineupType);
		if (extraLineup == null)
		{
			return false;
		}
		List<AvatarLineupData> avatarsFromTeam = base.Player.LineupManager.GetAvatarsFromTeam((int)(lineupType + 10));
		if (avatarsFromTeam.Count == 0)
		{
			return false;
		}
		foreach (AvatarLineupData item in avatarsFromTeam)
		{
			item.AvatarInfo.SetCurHp(10000, isExtraLineup: true);
			item.AvatarInfo.SetCurSp(5000, isExtraLineup: true);
		}
		extraLineup.Mp = base.Player.LineupManager.GetMaxMp();
		return true;
	}

	private async ValueTask<bool> TryEnterChallengeScene(int mapEntranceId)
	{
		if (mapEntranceId <= 0 || !GameData.MapEntranceData.ContainsKey(mapEntranceId))
		{
			return false;
		}
		try
		{
			return await base.Player.EnterScene(mapEntranceId, 0, sendPacket: false) || base.Player.Data.EntryId == mapEntranceId;
		}
		catch
		{
			return false;
		}
	}
}
