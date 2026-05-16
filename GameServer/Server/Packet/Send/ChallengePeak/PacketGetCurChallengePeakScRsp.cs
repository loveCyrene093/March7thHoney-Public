using System.Linq;
using March7thHoney.GameServer.Game.Challenge.Instances;
using March7thHoney.GameServer.Game.Player;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;

public class PacketGetCurChallengePeakScRsp : BasePacket
{
	public PacketGetCurChallengePeakScRsp(PlayerInstance player)
		: base(8944)
	{
		GetCurChallengePeakScRsp getCurChallengePeakScRsp = new GetCurChallengePeakScRsp();
		if (player.ChallengeManager.ChallengeInstance is ChallengePeakInstance challengePeakInstance)
		{
			getCurChallengePeakScRsp.HasPassed = true;
			getCurChallengePeakScRsp.PeakId = challengePeakInstance.Data.Peak.CurrentPeakLevelId;
			getCurChallengePeakScRsp.BossBuffId = challengePeakInstance.Data.Peak.Buffs.FirstOrDefault(0u);
			getCurChallengePeakScRsp.CyclesUsed = challengePeakInstance.Data.Peak.RoundCnt;
		}
		SetData(getCurChallengePeakScRsp);
	}
}
