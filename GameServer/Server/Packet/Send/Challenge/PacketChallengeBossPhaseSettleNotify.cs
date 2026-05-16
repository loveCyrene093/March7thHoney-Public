using Google.Protobuf.Collections;
using March7thHoney.GameServer.Game.Challenge.Instances;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Challenge;

public class PacketChallengeBossPhaseSettleNotify : BasePacket
{
	public PacketChallengeBossPhaseSettleNotify(ChallengeBossInstance challenge, BattleTargetList? targetLists = null)
		: base(1796)
	{
		ChallengeBossPhaseSettleNotify challengeBossPhaseSettleNotify = new ChallengeBossPhaseSettleNotify
		{
			ChallengeId = (uint)challenge.Config.ID,
			IsWin = challenge.IsWin,
			ChallengeScore = challenge.Data.Boss.ScoreStage1,
			ScoreTwo = challenge.Data.Boss.ScoreStage2,
			Star = challenge.Data.Boss.Stars,
			Phase = challenge.Data.Boss.CurrentStage,
			IsReward = true,
			PageType = 1u
		};
		challengeBossPhaseSettleNotify.BattleTargetList.AddRange(targetLists?.BattleTargetList_ ?? new RepeatedField<BattleTarget>());
		SetData(challengeBossPhaseSettleNotify);
	}
}
