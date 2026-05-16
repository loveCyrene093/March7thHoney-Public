using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Challenge;

public class PacketTakeChallengeRewardScRsp : BasePacket
{
	public PacketTakeChallengeRewardScRsp(int groupId, List<TakenChallengeRewardInfo>? rewardInfos)
		: base(1738)
	{
		TakeChallengeRewardScRsp takeChallengeRewardScRsp = new TakeChallengeRewardScRsp();
		if (rewardInfos != null)
		{
			takeChallengeRewardScRsp.GroupId = (uint)groupId;
			foreach (TakenChallengeRewardInfo rewardInfo in rewardInfos)
			{
				takeChallengeRewardScRsp.TakenRewardList.Add(rewardInfo);
			}
		}
		else
		{
			takeChallengeRewardScRsp.Retcode = 1u;
		}
		SetData(takeChallengeRewardScRsp);
	}
}
