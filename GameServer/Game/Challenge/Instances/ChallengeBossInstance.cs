using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
using March7thHoney.Database.Friend;
using March7thHoney.Database.Inventory;
using March7thHoney.Database.Lineup;
using March7thHoney.Enums.Item;
using March7thHoney.Enums.Mission;
using March7thHoney.GameServer.Game.Battle;
using March7thHoney.GameServer.Game.Challenge.Definitions;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.GameServer.Game.Scene.Entity;
using March7thHoney.GameServer.Server.Packet.Send.Challenge;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.Proto;
using March7thHoney.Proto.ServerSide;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Challenge.Instances;

public class ChallengeBossInstance(PlayerInstance player, ChallengeDataPb data) : BaseLegacyChallengeInstance(player, data)
{
	public override ChallengeConfigExcel Config { get; } = GameData.ChallengeConfigData[(int)data.Boss.ChallengeMazeId];

	public override uint GetStars()
	{
		return base.Data.Boss.Stars;
	}

	public override uint GetScore1()
	{
		return base.Data.Boss.ScoreStage1;
	}

	public override uint GetScore2()
	{
		return base.Data.Boss.ScoreStage2;
	}

	public void SetCurrentExtraLineup(ExtraLineupType type)
	{
		base.Data.Boss.CurrentExtraLineup = (ChallengeLineupTypePb)type;
	}

	public int GetTotalScore()
	{
		return (int)(base.Data.Boss.ScoreStage1 + base.Data.Boss.ScoreStage2);
	}

	public override int GetCurrentExtraLineupType()
	{
		return (int)base.Data.Boss.CurrentExtraLineup;
	}

	public override void SetStartPos(Position pos)
	{
		base.Data.Boss.StartPos = pos.ToVector3Pb();
	}

	public override void SetStartRot(Position rot)
	{
		base.Data.Boss.StartRot = rot.ToVector3Pb();
	}

	public override void SetSavedMp(int mp)
	{
		base.Data.Boss.SavedMp = (uint)mp;
	}

	public override Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> GetStageMonsters()
	{
		if (base.Data.Boss.CurrentStage != 1)
		{
			return Config.ChallengeMonsters2;
		}
		return Config.ChallengeMonsters1;
	}

	public override CurChallenge ToProto()
	{
		return new CurChallenge
		{
			ChallengeId = base.Data.Boss.ChallengeMazeId,
			ExtraLineupType = (ExtraLineupType)base.Data.Boss.CurrentExtraLineup,
			Status = (ChallengeStatus)base.Data.Boss.CurStatus,
			StageInfo = new ChallengeCurBuffInfo
			{
				CurBossBuffs = new ChallengeBossBuffList
				{
					BuffList = { (IEnumerable<uint>)base.Data.Boss.Buffs },
					ChallengeBossConst = 1u
				}
			},
			RoundCount = (uint)Config.ChallengeCountDown,
			ScoreId = base.Data.Boss.ScoreStage1,
			ScoreTwo = base.Data.Boss.ScoreStage2
		};
	}

	public override ChallengeStageInfo ToStageInfo()
	{
		ChallengeStageInfo challengeStageInfo = new ChallengeStageInfo
		{
			BossInfo = new ChallengeBossInfo
			{
				FirstNode = new ChallengeBossSingleNodeInfo
				{
					BuffId = base.Data.Boss.Buffs[0]
				},
				SecondNode = new ChallengeBossSingleNodeInfo
				{
					BuffId = base.Data.Boss.Buffs[1]
				},
				Unk1 = true
			}
		};
		foreach (LineupAvatarInfo item in base.Player.LineupManager?.GetExtraLineup(ExtraLineupType.LineupChallenge)?.BaseAvatars ?? new List<LineupAvatarInfo>())
		{
			FormalAvatarInfo formalAvatarInfo = base.Player.AvatarManager?.GetFormalAvatar(item.BaseAvatarId);
			if (formalAvatarInfo == null)
			{
				continue;
			}
			challengeStageInfo.BossInfo.FirstLineup.Add((uint)formalAvatarInfo.AvatarId);
			ItemData itemData = base.Player.InventoryManager?.GetItem(0, formalAvatarInfo.GetCurPathInfo().EquipId, ItemMainTypeEnum.Equipment);
			if (itemData != null)
			{
				challengeStageInfo.BossInfo.ChallengeAvatarEquipmentMap.Add((uint)formalAvatarInfo.AvatarId, itemData.ToChallengeEquipmentProto());
			}
			ChallengeBossAvatarRelicInfo challengeBossAvatarRelicInfo = new ChallengeBossAvatarRelicInfo();
			foreach (KeyValuePair<int, int> item2 in formalAvatarInfo.GetCurPathInfo().Relic)
			{
				ItemData itemData2 = base.Player.InventoryManager?.GetItem(0, item2.Value, ItemMainTypeEnum.Relic);
				if (itemData2 != null)
				{
					challengeBossAvatarRelicInfo.AvatarRelicSlotMap.Add((uint)item2.Key, itemData2.ToChallengeRelicProto());
				}
			}
			challengeStageInfo.BossInfo.ChallengeAvatarRelicMap.Add((uint)formalAvatarInfo.AvatarId, challengeBossAvatarRelicInfo);
		}
		foreach (LineupAvatarInfo item3 in base.Player.LineupManager?.GetExtraLineup(ExtraLineupType.LineupChallenge2)?.BaseAvatars ?? new List<LineupAvatarInfo>())
		{
			FormalAvatarInfo formalAvatarInfo2 = base.Player.AvatarManager?.GetFormalAvatar(item3.BaseAvatarId);
			if (formalAvatarInfo2 == null)
			{
				continue;
			}
			challengeStageInfo.BossInfo.SecondLineup.Add((uint)formalAvatarInfo2.AvatarId);
			ItemData itemData3 = base.Player.InventoryManager?.GetItem(0, formalAvatarInfo2.GetCurPathInfo().EquipId, ItemMainTypeEnum.Equipment);
			if (itemData3 != null)
			{
				challengeStageInfo.BossInfo.ChallengeAvatarEquipmentMap.Add((uint)formalAvatarInfo2.AvatarId, itemData3.ToChallengeEquipmentProto());
			}
			ChallengeBossAvatarRelicInfo challengeBossAvatarRelicInfo2 = new ChallengeBossAvatarRelicInfo();
			foreach (KeyValuePair<int, int> item4 in formalAvatarInfo2.GetCurPathInfo().Relic)
			{
				ItemData itemData4 = base.Player.InventoryManager?.GetItem(0, item4.Value, ItemMainTypeEnum.Relic);
				if (itemData4 != null)
				{
					challengeBossAvatarRelicInfo2.AvatarRelicSlotMap.Add((uint)item4.Key, itemData4.ToChallengeRelicProto());
				}
			}
			challengeStageInfo.BossInfo.ChallengeAvatarRelicMap.Add((uint)formalAvatarInfo2.AvatarId, challengeBossAvatarRelicInfo2);
		}
		return challengeStageInfo;
	}

	public override void OnBattleStart(BattleInstance battle)
	{
		base.OnBattleStart(battle);
		battle.RoundLimit = Config.ChallengeCountDown;
		battle.Buffs.Add(new MazeBuff(Config.MazeBuffID, 1, -1)
		{
			WaveFlag = -1
		});
		battle.AddBattleTarget(1, 90004, 0);
		battle.AddBattleTarget(1, 90005, 0);
		if (base.Data.Boss.Buffs.Count >= base.Data.Boss.CurrentStage)
		{
			uint buffID = base.Data.Boss.Buffs[(int)(base.Data.Boss.CurrentStage - 1)];
			battle.Buffs.Add(new MazeBuff((int)buffID, 1, -1)
			{
				WaveFlag = -1
			});
		}
	}

	public override async ValueTask OnBattleEnd(BattleInstance battle, PVEBattleResultCsReq req)
	{
		int num = 0;
		foreach (BattleTarget item in req.Stt.BattleTargetInfo[1u].BattleTargetList_)
		{
			num += (int)item.Progress;
		}
		if (base.Data.Boss.CurrentStage == 1)
		{
			base.Data.Boss.ScoreStage1 = (uint)num;
		}
		else
		{
			base.Data.Boss.ScoreStage2 = (uint)num;
		}
		switch (req.EndStatus)
		{
		case BattleEndStatus.BattleEndWin:
			if (base.Player.SceneInstance.Entities.Values.OfType<EntityMonster>().Count() == 0L)
			{
				await AdvanceStage(req);
			}
			base.Data.Boss.SavedMp = (uint)base.Player.LineupManager.GetCurLineup().Mp;
			return;
		case BattleEndStatus.BattleEndQuit:
		{
			March7thHoney.Database.Lineup.LineupInfo lineup = base.Player.LineupManager.GetCurLineup();
			lineup.Mp = (int)base.Data.Boss.SavedMp;
			await base.Player.MoveTo(base.Data.Boss.StartPos.ToPosition(), base.Data.Boss.StartRot.ToPosition());
			await base.Player.SendPacket(new PacketSyncLineupNotify(lineup));
			return;
		}
		}
		if (req.Stt.EndReason == BattleEndReason.TurnLimit)
		{
			await AdvanceStage(req);
			return;
		}
		base.Data.Boss.CurStatus = 3u;
		await base.Player.SendPacket(new PacketChallengeBossPhaseSettleNotify(this));
	}

	public uint CalculateStars()
	{
		List<int> challengeTargetID = Config.ChallengeTargetID;
		uint num = 0u;
		for (int i = 0; i < challengeTargetID.Count; i++)
		{
			if (GameData.ChallengeTargetData.ContainsKey(challengeTargetID[i]))
			{
				ChallengeTargetExcel challengeTargetExcel = GameData.ChallengeTargetData[challengeTargetID[i]];
				if (challengeTargetExcel.ChallengeTargetType == ChallengeTargetExcel.ChallengeType.TOTAL_SCORE && GetTotalScore() >= challengeTargetExcel.ChallengeTargetParam1)
				{
					num += (uint)(1 << i);
				}
			}
		}
		return Math.Min(num, 7u);
	}

	private async ValueTask AdvanceStage(PVEBattleResultCsReq req)
	{
		if (base.Data.Boss.CurrentStage >= Config.StageNum)
		{
			base.Data.Boss.CurStatus = 2u;
			base.Data.Boss.Stars = CalculateStars();
			base.Player.ChallengeManager.AddHistory((int)base.Data.Boss.ChallengeMazeId, (int)GetStars(), GetTotalScore());
			await base.Player.SendPacket(new PacketChallengeBossPhaseSettleNotify(this, req.Stt.BattleTargetInfo[1u]));
			await base.Player.SendPacket(new PacketChallengeSettleNotify(this));
			await base.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.ChallengeFinish, this);
			base.Player.ChallengeManager.SaveBattleRecord(this);
			base.Player.FriendRecordData.AddAndRemoveOld(new FriendDevelopmentInfoPb
			{
				DevelopmentType = DevelopmentType.KghodpfjgliGnameakebnl,
				Params = { 
				{
					"ChallengeId",
					(uint)Config.ID
				} }
			});
		}
		else
		{
			await base.Player.SendPacket(new PacketChallengeBossPhaseSettleNotify(this, req.Stt.BattleTargetInfo[1u]));
		}
	}

	public async ValueTask NextPhase()
	{
		base.Data.Boss.CurrentStage++;
		await base.Player.SceneInstance.EntityLoader.UnloadGroup(Config.MazeGroupID1);
		await base.Player.SceneInstance.EntityLoader.LoadGroup(Config.MazeGroupID2);
		SetCurrentExtraLineup(ExtraLineupType.LineupChallenge2);
		await base.Player.LineupManager.SetExtraLineup((ExtraLineupType)GetCurrentExtraLineupType());
		await base.Player.SendPacket(new PacketChallengeLineupNotify((ExtraLineupType)GetCurrentExtraLineupType()));
		await base.Player.SceneInstance.SyncLineup();
		base.Data.Boss.SavedMp = (uint)base.Player.LineupManager.GetCurLineup().Mp;
		if (Config.MapEntranceID2 == 0)
		{
			await base.Player.MoveTo(base.Data.Boss.StartPos.ToPosition(), base.Data.Boss.StartRot.ToPosition());
		}
		else
		{
			await base.Player.EnterScene(Config.MapEntranceID2, 0, sendPacket: false);
			base.Data.Boss.StartPos = base.Player.Data.Pos.ToVector3Pb();
			base.Data.Boss.StartRot = base.Player.Data.Rot.ToVector3Pb();
			await base.Player.SceneInstance.EntityLoader.LoadGroup(Config.MazeGroupID2);
		}
		base.Player.ChallengeManager.SaveInstance(this);
	}
}
