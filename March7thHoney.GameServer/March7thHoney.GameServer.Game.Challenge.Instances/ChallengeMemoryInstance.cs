using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Database.Avatar;
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

public class ChallengeMemoryInstance : BaseLegacyChallengeInstance
{
	public override ChallengeConfigExcel Config { get; }

	public ChallengeMemoryInstance(PlayerInstance player, ChallengeDataPb data)
	{
		Config = GameData.ChallengeConfigData[(int)data.Memory.ChallengeMazeId];
		base._002Ector(player, data);
	}

	public override CurChallenge ToProto()
	{
		return new CurChallenge
		{
			ChallengeId = base.Data.Memory.ChallengeMazeId,
			DeadAvatarNum = base.Data.Memory.DeadAvatarNum,
			ExtraLineupType = (ExtraLineupType)base.Data.Memory.CurrentExtraLineup,
			Status = (ChallengeStatus)base.Data.Memory.CurStatus,
			StageInfo = new ChallengeCurBuffInfo(),
			RoundCount = (uint)(Config.ChallengeCountDown - base.Data.Memory.RoundsLeft)
		};
	}

	public void SetCurrentExtraLineup(ExtraLineupType type)
	{
		base.Data.Memory.CurrentExtraLineup = (ChallengeLineupTypePb)type;
	}

	public override Dictionary<int, List<ChallengeConfigExcel.ChallengeMonsterInfo>> GetStageMonsters()
	{
		if (base.Data.Memory.CurrentStage != 1)
		{
			return Config.ChallengeMonsters2;
		}
		return Config.ChallengeMonsters1;
	}

	public override uint GetStars()
	{
		return base.Data.Memory.Stars;
	}

	public override int GetCurrentExtraLineupType()
	{
		return (int)base.Data.Memory.CurrentExtraLineup;
	}

	public override void SetStartPos(Position pos)
	{
		base.Data.Memory.StartPos = pos.ToVector3Pb();
	}

	public override void SetStartRot(Position rot)
	{
		base.Data.Memory.StartRot = rot.ToVector3Pb();
	}

	public override void SetSavedMp(int mp)
	{
		base.Data.Memory.SavedMp = (uint)mp;
	}

	public override void OnBattleStart(BattleInstance battle)
	{
		base.OnBattleStart(battle);
		battle.RoundLimit = (int)base.Data.Memory.RoundsLeft;
		battle.Buffs.Add(new MazeBuff(Config.MazeBuffID, 1, -1)
		{
			WaveFlag = -1
		});
	}

	public override async ValueTask OnBattleEnd(BattleInstance battle, PVEBattleResultCsReq req)
	{
		switch (req.EndStatus)
		{
		case BattleEndStatus.BattleEndWin:
			foreach (FormalAvatarInfo formalAvatar in battle.Lineup.AvatarData.FormalAvatars)
			{
				if (formalAvatar.CurrentHp <= 0)
				{
					base.Data.Memory.DeadAvatarNum++;
				}
			}
			if (base.Player.SceneInstance.Entities.Values.OfType<EntityMonster>().Count() == 0L)
			{
				await AdvanceStage();
			}
			base.Data.Memory.RoundsLeft = Math.Min(Math.Max(base.Data.Memory.RoundsLeft - req.Stt.RoundCnt, 1u), base.Data.Memory.RoundsLeft);
			base.Data.Memory.SavedMp = (uint)base.Player.LineupManager.GetCurLineup().Mp;
			break;
		case BattleEndStatus.BattleEndQuit:
		{
			March7thHoney.Database.Lineup.LineupInfo lineup = base.Player.LineupManager.GetCurLineup();
			lineup.Mp = (int)base.Data.Memory.SavedMp;
			await base.Player.MoveTo(base.Data.Memory.StartPos.ToPosition(), base.Data.Memory.StartRot.ToPosition());
			await base.Player.SendPacket(new PacketSyncLineupNotify(lineup));
			break;
		}
		default:
			base.Data.Memory.CurStatus = 3u;
			await base.Player.SendPacket(new PacketChallengeSettleNotify(this));
			break;
		}
	}

	public uint CalculateStars()
	{
		List<int> challengeTargetID = Config.ChallengeTargetID;
		uint num = 0u;
		for (int i = 0; i < challengeTargetID.Count; i++)
		{
			if (!GameData.ChallengeTargetData.ContainsKey(challengeTargetID[i]))
			{
				continue;
			}
			ChallengeTargetExcel challengeTargetExcel = GameData.ChallengeTargetData[challengeTargetID[i]];
			switch (challengeTargetExcel.ChallengeTargetType)
			{
			case ChallengeTargetExcel.ChallengeType.ROUNDS_LEFT:
				if (base.Data.Memory.RoundsLeft >= challengeTargetExcel.ChallengeTargetParam1)
				{
					num += (uint)(1 << i);
				}
				break;
			case ChallengeTargetExcel.ChallengeType.DEAD_AVATAR:
				if (base.Data.Memory.DeadAvatarNum == 0)
				{
					num += (uint)(1 << i);
				}
				break;
			}
		}
		return Math.Min(num, 7u);
	}

	private async ValueTask AdvanceStage()
	{
		if (base.Data.Memory.CurrentStage >= Config.StageNum)
		{
			base.Data.Memory.CurStatus = 2u;
			base.Data.Memory.Stars = CalculateStars();
			base.Player.ChallengeManager.AddHistory((int)base.Data.Memory.ChallengeMazeId, (int)base.Data.Memory.Stars, 0);
			await base.Player.SendPacket(new PacketChallengeSettleNotify(this));
			await base.Player.MissionManager.HandleFinishType(MissionFinishTypeEnum.ChallengeFinish, this);
			base.Player.ChallengeManager.SaveBattleRecord(this);
			base.Player.FriendRecordData.AddAndRemoveOld(new FriendDevelopmentInfoPb
			{
				DevelopmentType = DevelopmentType.KghodpfjgliBpajghjgcam,
				Params = { 
				{
					"ChallengeId",
					(uint)Config.ID
				} }
			});
		}
		else
		{
			base.Data.Memory.CurrentStage++;
			SetCurrentExtraLineup(ExtraLineupType.LineupChallenge2);
			await base.Player.LineupManager.SetExtraLineup((ExtraLineupType)GetCurrentExtraLineupType());
			int entryId = ((Config.MapEntranceID2 != 0) ? Config.MapEntranceID2 : Config.MapEntranceID);
			await base.Player.EnterScene(entryId, 0, sendPacket: true);
			await base.Player.SendPacket(new PacketChallengeLineupNotify((ExtraLineupType)base.Data.Memory.CurrentExtraLineup));
			base.Data.Memory.SavedMp = (uint)base.Player.LineupManager.GetCurLineup().Mp;
			base.Data.Memory.StartPos = base.Player.Data.Pos.ToVector3Pb();
			base.Data.Memory.StartRot = base.Player.Data.Rot.ToVector3Pb();
			base.Player.ChallengeManager.SaveInstance(this);
		}
	}
}
