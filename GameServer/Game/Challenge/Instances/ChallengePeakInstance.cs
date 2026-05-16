using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Friend;
using March7thHoney.Database.Lineup;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.Proto;
using March7thHoney.Proto.ServerSide;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Challenge.Instances;

public class ChallengePeakInstance(PlayerInstance player, ChallengeDataPb data) : BaseChallengeInstance(player, data)
{
	public ChallengePeakConfigExcel Config { get; } = GameData.ChallengePeakConfigData[(int)data.Peak.CurrentPeakLevelId];

	public List<int> AllBattleTargets { get; } = new List<int>();

	public bool IsWin { get; private set; }

	public override Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> GetStageMonsters()
	{
		if (!base.Data.Peak.IsHard || Config.BossExcel == null)
		{
			return Config.ChallengeMonsters;
		}
		Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> dictionary = new Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>>();
		int mazeGroupId = Config.GetMazeGroupId();
		dictionary.Add(mazeGroupId, new List<ChallengeConfigExcel.ChallengeMonsterInfo>());
		int num = 200000;
		foreach (int hardEventID in Config.BossExcel.HardEventIDList)
		{
			if (!GameData.StageConfigData.TryGetValue(hardEventID, out StageConfigExcel value))
			{
				continue;
			}
			int key = value.MonsterList.LastOrDefault()?.Monster0 ?? 0;
			if (GameData.MonsterConfigData.TryGetValue(key, out MonsterConfigExcel value2) && GameData.MonsterTemplateConfigData.TryGetValue(value2.MonsterTemplateID, out MonsterTemplateConfigExcel value3))
			{
				int num2 = value3.NPCMonsterList.Take(2).LastOrDefault(0);
				if (GameData.NpcMonsterDataData.ContainsKey(num2))
				{
					dictionary[mazeGroupId].Add(new ChallengeConfigExcel.ChallengeMonsterInfo(++num, num2, hardEventID));
				}
			}
		}
		return dictionary;
	}

	public override void OnBattleStart(BattleInstance battle)
	{
		base.OnBattleStart(battle);
		foreach (uint buff in base.Data.Peak.Buffs)
		{
			battle.Buffs.Add(new MazeBuff((int)buff, 1, -1)
			{
				WaveFlag = -1
			});
		}
		if (base.Data.Peak.IsHard && Config.BossExcel != null)
		{
			BattleTargetConfigExcel valueOrDefault = GameData.BattleTargetConfigData.GetValueOrDefault(Config.BossExcel.HardTarget);
			if (valueOrDefault != null)
			{
				battle.AddBattleTarget(5, valueOrDefault.ID, 0, valueOrDefault.TargetParam);
				AllBattleTargets.Add(valueOrDefault.ID);
			}
			return;
		}
		foreach (int normalTarget in Config.NormalTargetList)
		{
			BattleTargetConfigExcel valueOrDefault2 = GameData.BattleTargetConfigData.GetValueOrDefault(normalTarget);
			if (valueOrDefault2 != null)
			{
				battle.AddBattleTarget(5, valueOrDefault2.ID, 0, valueOrDefault2.TargetParam);
				AllBattleTargets.Add(valueOrDefault2.ID);
			}
		}
	}

	public override async ValueTask OnBattleEnd(BattleInstance battle, PVEBattleResultCsReq req)
	{
		switch (req.EndStatus)
		{
		case BattleEndStatus.BattleEndWin:
			if (base.Player.SceneInstance.Entities.Values.OfType<EntityMonster>().Count() == 0L)
			{
				base.Data.Peak.CurStatus = 2u;
				(uint, List<uint>) res = CalculateStars(req);
				base.Data.Peak.Stars = res.Item1;
				base.Data.Peak.RoundCnt = req.Stt.RoundCnt;
				IsWin = true;
				await base.Player.SendPacket(new PacketChallengePeakSettleScNotify(this, res.Item2));
				await base.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.ChallengePeakBattleFinish, this);
				await base.Player.ChallengePeakManager.SaveHistory(this, res.Item2);
				base.Player.FriendRecordData.AddAndRemoveOld(new FriendDevelopmentInfoPb
				{
					DevelopmentType = DevelopmentType.KghodpfjgliMjfldkhkdab,
					Params = { 
					{
						"PeakLevelId",
						(uint)Config.ID
					} }
				});
			}
			base.Data.Peak.SavedMp = (uint)base.Player.LineupManager.GetCurLineup().Mp;
			break;
		case BattleEndStatus.BattleEndQuit:
		{
			March7thHoney.Database.Lineup.LineupInfo lineup = base.Player.LineupManager.GetCurLineup();
			lineup.Mp = (int)base.Data.Peak.SavedMp;
			if (base.Data.Peak.StartPos != null && base.Data.Peak.StartRot != null)
			{
				await base.Player.MoveTo(base.Data.Peak.StartPos.ToPosition(), base.Data.Peak.StartRot.ToPosition());
			}
			await base.Player.SendPacket(new PacketSyncLineupNotify(lineup));
			break;
		}
		default:
			base.Data.Peak.CurStatus = 3u;
			await base.Player.SendPacket(new PacketChallengePeakSettleScNotify(this, new List<uint>()));
			break;
		}
	}

	public (uint, List<uint>) CalculateStars(PVEBattleResultCsReq req)
	{
		List<int> allBattleTargets = AllBattleTargets;
		uint num = 0u;
		List<uint> list = new List<uint>();
		foreach (int targetId in allBattleTargets)
		{
			BattleTarget battleTarget = req.Stt.BattleTargetInfo[5u].BattleTargetList_.FirstOrDefault((BattleTarget x) => x.Id == targetId);
			if (battleTarget != null)
			{
				BattleTargetConfigExcel valueOrDefault = GameData.BattleTargetConfigData.GetValueOrDefault(targetId);
				if (valueOrDefault != null && battleTarget.Progress <= valueOrDefault.TargetParam)
				{
					num++;
					list.Add((uint)targetId);
				}
			}
		}
		if (base.Data.Peak.IsHard && Config.BossExcel != null)
		{
			num = 3u;
		}
		return (Math.Min(num, 3u), list);
	}
}
