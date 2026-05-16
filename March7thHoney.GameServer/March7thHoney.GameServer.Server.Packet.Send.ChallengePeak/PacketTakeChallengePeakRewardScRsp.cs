using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.ChallengePeak;

public class PacketTakeChallengePeakRewardScRsp : BasePacket
{
	public PacketTakeChallengePeakRewardScRsp(uint peakGroupId, List<ChallengePeakRewardGroup>? rewardGroups)
		: base(8919)
	{
		TakeChallengePeakRewardScRsp takeChallengePeakRewardScRsp = new TakeChallengePeakRewardScRsp
		{
			PeakGroupId = peakGroupId
		};
		if (rewardGroups == null)
		{
			takeChallengePeakRewardScRsp.Retcode = 1u;
		}
		else
		{
			takeChallengePeakRewardScRsp.PeakRewardGroupList.AddRange(rewardGroups);
		}
		SetData(takeChallengePeakRewardScRsp);
	}
}
