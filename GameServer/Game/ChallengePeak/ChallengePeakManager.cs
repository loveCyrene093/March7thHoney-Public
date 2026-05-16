using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Challenge;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.GameServer.Game.Challenge.Instances;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;
using March7thHoney.Proto;
using March7thHoney.Proto.ServerSide;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.ChallengePeak;

public class ChallengePeakManager(PlayerInstance player) : BasePlayerManager(player)
{
	public bool BossIsHard { get; set; } = true;

	public ChallengePeakGroup GetChallengePeakInfo(int groupId)
	{
		ChallengePeakGroup challengePeakGroup = new ChallengePeakGroup
		{
			PeakGroupId = (uint)groupId
		};
		ChallengePeakGroupConfigExcel valueOrDefault = GameData.ChallengePeakGroupConfigData.GetValueOrDefault(groupId);
		if (valueOrDefault == null)
		{
			return challengePeakGroup;
		}
		int num = 0;
		foreach (int preLevelID in valueOrDefault.PreLevelIDList)
		{
			if (GameData.ChallengePeakConfigData.GetValueOrDefault(preLevelID) != null)
			{
				March7thHoney.Proto.ChallengePeak challengePeak = new March7thHoney.Proto.ChallengePeak
				{
					PeakId = (uint)preLevelID,
					HasPassed = true
				};
				if (base.Player.ChallengeManager.ChallengeData.PeakLevelDatas.TryGetValue(preLevelID, out ChallengePeakLevelData value))
				{
					num += (int)value.PeakStar;
					challengePeak.CyclesUsed = value.RoundCnt;
					challengePeak.PeakAvatarIdList.AddRange(value.BaseAvatarList);
					challengePeak.FinishedTargetList.AddRange(value.FinishedTargetList);
				}
				challengePeakGroup.Peaks.Add(challengePeak);
			}
		}
		challengePeakGroup.ObtainedStars = (uint)num;
		challengePeakGroup.CountOfPeaks = (uint)challengePeakGroup.Peaks.Count;
		if (base.Player.ChallengeManager.ChallengeData.PeakTakenRewardIds.TryGetValue(groupId, out List<int> value2))
		{
			challengePeakGroup.TakenStarRewards.AddRange(value2.Select((int x) => (uint)x));
		}
		int bossLevelID = valueOrDefault.BossLevelID;
		if (bossLevelID <= 0)
		{
			return challengePeakGroup;
		}
		if (GameData.ChallengePeakBossConfigData.GetValueOrDefault(bossLevelID) == null)
		{
			return challengePeakGroup;
		}
		ChallengePeakBoss challengePeakBoss = new ChallengePeakBoss
		{
			LJGDCGBFNKN = (uint)bossLevelID,
			HardModeHasPassed = true,
			EasyMode = new ChallengePeakBossClearance(),
			HardMode = new ChallengePeakBossClearance()
		};
		HashSet<uint> hashSet = new HashSet<uint>();
		if (base.Player.ChallengeManager.ChallengeData.PeakBossLevelDatas.TryGetValue((bossLevelID << 2) | 0, out ChallengePeakBossLevelData value3))
		{
			challengePeakBoss.EasyMode.PeakAvatarIdList.AddRange(value3.BaseAvatarList);
			challengePeakBoss.EasyMode.BestCycleCount = value3.RoundCnt;
			challengePeakBoss.EasyMode.HasPassed = true;
			challengePeakBoss.EasyMode.BuffId = value3.BuffId;
			foreach (uint finishedTarget in value3.FinishedTargetList)
			{
				hashSet.Add(finishedTarget);
			}
		}
		if (base.Player.ChallengeManager.ChallengeData.PeakBossLevelDatas.TryGetValue((bossLevelID << 2) | 1, out ChallengePeakBossLevelData value4))
		{
			challengePeakBoss.HardModeHasPassed = true;
			challengePeakBoss.HardMode.PeakAvatarIdList.AddRange(value4.BaseAvatarList);
			challengePeakBoss.HardMode.BestCycleCount = value4.RoundCnt;
			challengePeakBoss.HardMode.HasPassed = true;
			challengePeakBoss.HardMode.BuffId = value4.BuffId;
			foreach (uint finishedTarget2 in value4.FinishedTargetList)
			{
				hashSet.Add(finishedTarget2);
			}
		}
		challengePeakBoss.FinishedTargetList.AddRange(hashSet);
		challengePeakGroup.PeakBoss = challengePeakBoss;
		return challengePeakGroup;
	}

	public async ValueTask<List<ChallengePeakRewardGroup>?> TakeRewards(int groupId, IEnumerable<uint> requestRewardIds)
	{
		if (!GameData.ChallengePeakGroupConfigData.TryGetValue(groupId, out ChallengePeakGroupConfigExcel value))
		{
			return null;
		}
		if (!GameData.ChallengePeakRewardData.TryGetValue(value.RewardGroupID, out List<ChallengePeakRewardExcel> value2))
		{
			return null;
		}
		int count = value.PreLevelIDList.Count;
		int num = count * 3;
		bool flag = value.BossLevelID > 0;
		int num2 = (flag ? 3 : 0);
		int num3 = (flag ? 3 : 0);
		if (!base.Player.ChallengeManager.ChallengeData.PeakTakenRewardIds.TryGetValue(groupId, out List<int> value3))
		{
			value3 = new List<int>();
			base.Player.ChallengeManager.ChallengeData.PeakTakenRewardIds[groupId] = value3;
		}
		HashSet<int> hashSet = requestRewardIds.Select((uint x) => (int)x).ToHashSet();
		if (hashSet.Count == 0)
		{
			hashSet = value2.Select((ChallengePeakRewardExcel x) => x.ID).ToHashSet();
		}
		List<ChallengePeakRewardGroup> rspGroups = new List<ChallengePeakRewardGroup>();
		List<ItemData> list = new List<ItemData>();
		foreach (ChallengePeakRewardExcel item3 in value2.OrderBy((ChallengePeakRewardExcel x) => x.ID))
		{
			if (!hashSet.Contains(item3.ID) || value3.Contains(item3.ID) || item3.RewardType switch
			{
				"MOB_PASS_REWARD" => (count >= item3.TypeValue) ? 1 : 0, 
				"MOB_STAR_REWARD" => (num >= item3.TypeValue) ? 1 : 0, 
				"BOSS_STAR_REWARD" => (num2 >= item3.TypeValue) ? 1 : 0, 
				"BOSS_STAR_LIMIT_REWARD" => (num3 >= item3.TypeValue) ? 1 : 0, 
				"BOSS_COLOR_TARGET_REWARD" => flag ? 1 : 0, 
				_ => 0, 
			} == 0 || !GameData.RewardDataData.TryGetValue(item3.RewardID, out RewardDataExcel value4))
			{
				continue;
			}
			ChallengePeakRewardGroup challengePeakRewardGroup = new ChallengePeakRewardGroup
			{
				RewardId = (uint)item3.ID,
				Reward = new ItemList()
			};
			if (value4.Hcoin > 0)
			{
				ItemData itemData = new ItemData
				{
					ItemId = 1,
					Count = value4.Hcoin
				};
				list.Add(itemData);
				challengePeakRewardGroup.Reward.ItemList_.Add(itemData.ToProto());
			}
			foreach (var item4 in value4.GetItems())
			{
				int item = item4.Item1;
				int item2 = item4.Item2;
				ItemData itemData2 = new ItemData
				{
					ItemId = item,
					Count = item2
				};
				list.Add(itemData2);
				challengePeakRewardGroup.Reward.ItemList_.Add(itemData2.ToProto());
			}
			value3.Add(item3.ID);
			rspGroups.Add(challengePeakRewardGroup);
		}
		if (list.Count > 0)
		{
			await base.Player.InventoryManager.AddItems(list);
		}
		return rspGroups;
	}

	private int GetObtainedStars(ChallengePeakGroupConfigExcel groupConfig)
	{
		int num = 0;
		foreach (int preLevelID in groupConfig.PreLevelIDList)
		{
			if (base.Player.ChallengeManager.ChallengeData.PeakLevelDatas.TryGetValue(preLevelID, out ChallengePeakLevelData value))
			{
				num += (int)value.PeakStar;
			}
		}
		if (groupConfig.BossLevelID > 0)
		{
			int key = (groupConfig.BossLevelID << 2) | 0;
			int key2 = (groupConfig.BossLevelID << 2) | 1;
			if (base.Player.ChallengeManager.ChallengeData.PeakBossLevelDatas.TryGetValue(key, out ChallengePeakBossLevelData value2))
			{
				num += (int)value2.PeakStar;
			}
			if (base.Player.ChallengeManager.ChallengeData.PeakBossLevelDatas.TryGetValue(key2, out ChallengePeakBossLevelData value3))
			{
				num += (int)value3.PeakStar;
			}
		}
		return num;
	}

	public async ValueTask SetLineupAvatars(int groupId, List<ChallengePeakLineup> lineups)
	{
		Dictionary<int, ChallengePeakLevelData> peakLevelDatas = base.Player.ChallengeManager.ChallengeData.PeakLevelDatas;
		foreach (ChallengePeakLineup lineup in lineups)
		{
			List<uint> list = new List<uint>();
			foreach (uint item in lineup.PeakAvatarIdList.ToList())
			{
				FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar((int)item);
				if (formalAvatar != null)
				{
					list.Add((uint)formalAvatar.BaseAvatarId);
				}
			}
			peakLevelDatas[(int)lineup.PeakId] = new ChallengePeakLevelData
			{
				LevelId = (int)lineup.PeakId,
				BaseAvatarList = list
			};
		}
		await base.Player.SendPacket(new PacketChallengePeakGroupDataUpdateScNotify(GetChallengePeakInfo(groupId)));
	}

	public async ValueTask SaveHistory(ChallengePeakInstance inst, List<uint> targetIds)
	{
		if (inst.Config.BossExcel != null)
		{
			bool isHard = inst.Data.Peak.IsHard;
			int key = (int)(inst.Data.Peak.CurrentPeakLevelId << 2) | (isHard ? 1 : 0);
			if (base.Player.ChallengeManager.ChallengeData.PeakBossLevelDatas.TryGetValue(key, out ChallengePeakBossLevelData value) && value.FinishedTargetList.Count > targetIds.Count && value.RoundCnt < inst.Data.Peak.RoundCnt)
			{
				return;
			}
			ChallengePeakBossLevelData challengePeakBossLevelData = new ChallengePeakBossLevelData
			{
				LevelId = (int)inst.Data.Peak.CurrentPeakLevelId,
				IsHard = isHard,
				BaseAvatarList = (base.Player.LineupManager.GetCurLineup()?.BaseAvatars?.Select((LineupAvatarInfo x) => (uint)x.BaseAvatarId).ToList() ?? new List<uint>()),
				RoundCnt = inst.Data.Peak.RoundCnt,
				BuffId = inst.Data.Peak.Buffs.FirstOrDefault(),
				FinishedTargetList = targetIds,
				PeakStar = (uint)targetIds.Count
			};
			base.Player.ChallengeManager.ChallengeData.PeakBossLevelDatas[key] = challengePeakBossLevelData;
			if (isHard)
			{
				await base.Player.SetPlayerHeadFrameId(226004u, long.MaxValue);
			}
			else
			{
				uint num = challengePeakBossLevelData.PeakStar + 226000;
				if (base.Player.Data.HeadFrame.HeadFrameId < num)
				{
					await base.Player.SetPlayerHeadFrameId(num, long.MaxValue);
				}
			}
		}
		else
		{
			int currentPeakLevelId = (int)inst.Data.Peak.CurrentPeakLevelId;
			if (base.Player.ChallengeManager.ChallengeData.PeakLevelDatas.TryGetValue(currentPeakLevelId, out ChallengePeakLevelData value2) && value2.FinishedTargetList.Count > targetIds.Count && value2.RoundCnt < inst.Data.Peak.RoundCnt)
			{
				return;
			}
			ChallengePeakLevelData value3 = new ChallengePeakLevelData
			{
				LevelId = currentPeakLevelId,
				BaseAvatarList = (base.Player.LineupManager.GetCurLineup()?.BaseAvatars?.Select((LineupAvatarInfo x) => (uint)x.BaseAvatarId).ToList() ?? new List<uint>()),
				RoundCnt = inst.Data.Peak.RoundCnt,
				FinishedTargetList = targetIds,
				PeakStar = (uint)targetIds.Count
			};
			base.Player.ChallengeManager.ChallengeData.PeakLevelDatas[currentPeakLevelId] = value3;
		}
		await base.Player.SendPacket(new PacketChallengePeakGroupDataUpdateScNotify(GetChallengePeakInfo((int)inst.Data.Peak.CurrentPeakGroupId)));
	}

	public async ValueTask StartChallenge(int levelId, uint buffId, List<int> avatarIdList)
	{
		if (!GameData.ChallengePeakConfigData.TryGetValue(levelId, out ChallengePeakConfigExcel excel))
		{
			await base.Player.SendPacket(new PacketStartChallengePeakScRsp(Retcode.RetChallengeNotExist));
			return;
		}
		List<int> list = new List<int>();
		foreach (int avatarId in avatarIdList)
		{
			FormalAvatarInfo formalAvatar = base.Player.AvatarManager.GetFormalAvatar(avatarId);
			if (formalAvatar != null)
			{
				list.Add(formalAvatar.BaseAvatarId);
			}
		}
		March7thHoney.Database.Lineup.LineupInfo extraLineup = base.Player.LineupManager.GetExtraLineup(ExtraLineupType.LineupChallenge);
		if (extraLineup == null)
		{
			base.Player.LineupManager.SetExtraLineup(ExtraLineupType.LineupChallenge, new List<int>());
			extraLineup = base.Player.LineupManager.GetExtraLineup(ExtraLineupType.LineupChallenge);
		}
		if (extraLineup == null)
		{
			await base.Player.SendPacket(new PacketStartChallengePeakScRsp(Retcode.RetChallengeLineupEmpty));
			return;
		}
		if (list.Count > 0)
		{
			extraLineup.BaseAvatars = list.Select((int x) => new LineupAvatarInfo
			{
				BaseAvatarId = x
			}).ToList();
		}
		else
		{
			extraLineup.BaseAvatars = base.Player.ChallengeManager.ChallengeData.PeakLevelDatas.GetValueOrDefault(levelId)?.BaseAvatarList.Select((uint x) => new LineupAvatarInfo
			{
				BaseAvatarId = (int)x
			}).ToList() ?? new List<LineupAvatarInfo>();
		}
		extraLineup.Mp = 8;
		if (base.Player.AvatarManager.AvatarData.FormalAvatars.Count == 0)
		{
			await base.Player.SendPacket(new PacketStartChallengePeakScRsp(Retcode.RetChallengeLineupEmpty));
			return;
		}
		foreach (FormalAvatarInfo formalAvatar2 in base.Player.AvatarManager.AvatarData.FormalAvatars)
		{
			formalAvatar2.SetCurHp(10000, isExtraLineup: true);
			formalAvatar2.SetCurSp(5000, isExtraLineup: true);
		}
		ChallengeDataPb data = new ChallengeDataPb
		{
			Peak = new ChallengePeakDataPb
			{
				CurrentPeakGroupId = (uint)(GameData.ChallengePeakGroupConfigData.Values.FirstOrDefault((ChallengePeakGroupConfigExcel x) => x.BossLevelID == levelId || x.PreLevelIDList.Contains(levelId))?.ID ?? GameData.GetCurrentChallengePeakGroupId()),
				CurrentPeakLevelId = (uint)levelId,
				CurrentExtraLineup = ChallengeLineupTypePb.Challenge1,
				CurStatus = 1u
			}
		};
		if (excel.BossExcel != null)
		{
			data.Peak.IsHard = BossIsHard;
		}
		if (buffId != 0)
		{
			data.Peak.Buffs.Add(buffId);
		}
		ChallengePeakInstance instance = new ChallengePeakInstance(base.Player, data);
		base.Player.ChallengeManager.ChallengeInstance = instance;
		await base.Player.LineupManager.SetExtraLineup((ExtraLineupType)instance.Data.Peak.CurrentExtraLineup);
		try
		{
			int num = excel.GetMapEntranceId();
			if (num <= 0)
			{
				num = GameData.ChallengePeakGroupConfigData.Values.FirstOrDefault((ChallengePeakGroupConfigExcel x) => x.BossLevelID == levelId || x.PreLevelIDList.Contains(levelId))?.MapEntranceID ?? 0;
			}
			if (num <= 0)
			{
				await base.Player.SendPacket(new PacketStartChallengePeakScRsp(Retcode.RetChallengeNotExist));
				return;
			}
			await base.Player.EnterScene(num, 0, sendPacket: true);
		}
		catch
		{
			base.Player.ChallengeManager.ChallengeInstance = null;
			await base.Player.SendPacket(new PacketStartChallengePeakScRsp(Retcode.RetChallengeNotExist));
			return;
		}
		data.Peak.StartPos = base.Player.Data.Pos.ToVector3Pb();
		data.Peak.StartPos = base.Player.Data.Rot.ToVector3Pb();
		data.Peak.SavedMp = (uint)base.Player.LineupManager.GetCurLineup().Mp;
		await base.Player.SendPacket(new PacketStartChallengePeakScRsp(Retcode.RetSucc));
		base.Player.ChallengeManager.SaveInstance(instance);
	}
}
