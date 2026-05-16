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
using March7thHoney.GameServer.Server.Packet.Send.Challenge;
using March7thHoney.GameServer.Server.Packet.Send.Lineup;
using March7thHoney.Proto;
using March7thHoney.Proto.ServerSide;
using March7thHoney.Util;

namespace March7thHoney.GameServer.Game.Challenge.Instances;

public class ChallengeStoryInstance : BaseLegacyChallengeInstance
{
	public override ChallengeConfigExcel Config { get; }

	public ChallengeStoryInstance(PlayerInstance player, ChallengeDataPb data)
	{
		Config = GameData.ChallengeConfigData[(int)data.Story.ChallengeMazeId];
		base._002Ector(player, data);
	}

	public override CurChallenge ToProto()
	{
		return new CurChallenge
		{
			ChallengeId = base.Data.Story.ChallengeMazeId,
			ExtraLineupType = (ExtraLineupType)base.Data.Story.CurrentExtraLineup,
			Status = (ChallengeStatus)base.Data.Story.CurStatus,
			StageInfo = new ChallengeCurBuffInfo
			{
				CurStoryBuffs = new ChallengeStoryBuffList
				{
					BuffList = { (IEnumerable<uint>)base.Data.Story.Buffs }
				}
			},
			RoundCount = (uint)Config.ChallengeCountDown,
			ScoreId = base.Data.Story.ScoreStage1,
			ScoreTwo = base.Data.Story.ScoreStage2
		};
	}

	public override uint GetStars()
	{
		return base.Data.Story.Stars;
	}

	public override uint GetScore1()
	{
		return base.Data.Story.ScoreStage1;
	}

	public override uint GetScore2()
	{
		return base.Data.Story.ScoreStage2;
	}

	public void SetCurrentExtraLineup(ExtraLineupType type)
	{
		base.Data.Story.CurrentExtraLineup = (ChallengeLineupTypePb)type;
	}

	public int GetTotalScore()
	{
		return (int)(base.Data.Story.ScoreStage1 + base.Data.Story.ScoreStage2);
	}

	public override int GetCurrentExtraLineupType()
	{
		return (int)base.Data.Story.CurrentExtraLineup;
	}

	public override void SetStartPos(Position pos)
	{
		base.Data.Story.StartPos = pos.ToVector3Pb();
	}

	public override void SetStartRot(Position rot)
	{
		base.Data.Story.StartRot = rot.ToVector3Pb();
	}

	public override void SetSavedMp(int mp)
	{
		base.Data.Story.SavedMp = (uint)mp;
	}

	public override Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> GetStageMonsters()
	{
		if (base.Data.Story.CurrentStage != 1)
		{
			return Config.ChallengeMonsters2;
		}
		return Config.ChallengeMonsters1;
	}

	public override void OnBattleStart(BattleInstance battle)
	{
		base.OnBattleStart(battle);
		battle.RoundLimit = Config.ChallengeCountDown;
		battle.Buffs.Add(new MazeBuff(Config.MazeBuffID, 1, -1)
		{
			WaveFlag = -1
		});
		if (Config.StoryExcel == null)
		{
			return;
		}
		battle.AddBattleTarget(1, 10002, GetTotalScore());
		foreach (int item in Config.StoryExcel.BattleTargetID)
		{
			battle.AddBattleTarget(5, item, GetTotalScore());
		}
		if (base.Data.Story.Buffs.Count >= base.Data.Story.CurrentStage)
		{
			uint buffID = base.Data.Story.Buffs[(int)(base.Data.Story.CurrentStage - 1)];
			battle.Buffs.Add(new MazeBuff((int)buffID, 1, -1)
			{
				WaveFlag = -1
			});
		}
	}

	public override async ValueTask OnBattleEnd(BattleInstance battle, PVEBattleResultCsReq req)
	{
		int num = (int)req.Stt.ChallengeScore - GetTotalScore();
		if (base.Data.Story.CurrentStage == 1)
		{
			base.Data.Story.ScoreStage1 = (uint)num;
		}
		else
		{
			base.Data.Story.ScoreStage2 = (uint)num;
		}
		switch (req.EndStatus)
		{
		case BattleEndStatus.BattleEndWin:
			if (base.Player.SceneInstance.Entities.Values.OfType<EntityMonster>().Count() == 0L)
			{
				await AdvanceStage();
			}
			base.Data.Story.SavedMp = (uint)base.Player.LineupManager.GetCurLineup().Mp;
			return;
		case BattleEndStatus.BattleEndQuit:
		{
			March7thHoney.Database.Lineup.LineupInfo lineup = base.Player.LineupManager.GetCurLineup();
			lineup.Mp = (int)base.Data.Story.SavedMp;
			await base.Player.MoveTo(base.Data.Story.StartPos.ToPosition(), base.Data.Story.StartRot.ToPosition());
			await base.Player.SendPacket(new PacketSyncLineupNotify(lineup));
			return;
		}
		}
		if (req.Stt.EndReason == BattleEndReason.TurnLimit)
		{
			await AdvanceStage();
			return;
		}
		base.Data.Story.CurStatus = 3u;
		await base.Player.SendPacket(new PacketChallengeSettleNotify(this));
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

	private async ValueTask AdvanceStage()
	{
		if (base.Data.Story.CurrentStage >= Config.StageNum)
		{
			base.Data.Story.CurStatus = 2u;
			base.Data.Story.Stars = CalculateStars();
			base.Player.ChallengeManager.AddHistory((int)base.Data.Story.ChallengeMazeId, (int)GetStars(), GetTotalScore());
			await base.Player.SendPacket(new PacketChallengeSettleNotify(this));
			await base.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.ChallengeFinish, this);
			base.Player.ChallengeManager.SaveBattleRecord(this);
			base.Player.FriendRecordData.AddAndRemoveOld(new FriendDevelopmentInfoPb
			{
				DevelopmentType = DevelopmentType.KghodpfjgliPpkfekfhfgb,
				Params = { 
				{
					"ChallengeId",
					(uint)Config.ID
				} }
			});
		}
		else
		{
			base.Data.Story.CurrentStage++;
			SetCurrentExtraLineup(ExtraLineupType.LineupChallenge2);
			await base.Player.LineupManager.SetExtraLineup((ExtraLineupType)GetCurrentExtraLineupType());
			int entryId = ((Config.MapEntranceID2 != 0) ? Config.MapEntranceID2 : Config.MapEntranceID);
			await base.Player.EnterScene(entryId, 0, sendPacket: true);
			await base.Player.SendPacket(new PacketChallengeLineupNotify((ExtraLineupType)base.Data.Story.CurrentExtraLineup));
			base.Data.Story.SavedMp = (uint)base.Player.LineupManager.GetCurLineup().Mp;
			base.Data.Story.StartPos = base.Player.Data.Pos.ToVector3Pb();
			base.Data.Story.StartRot = base.Player.Data.Rot.ToVector3Pb();
			base.Player.ChallengeManager.SaveInstance(this);
		}
	}
}
