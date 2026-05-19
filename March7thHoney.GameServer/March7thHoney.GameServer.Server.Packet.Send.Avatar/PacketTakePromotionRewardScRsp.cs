using System.Collections.Generic;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Avatar;

public class PacketTakePromotionRewardScRsp : BasePacket
{
	public PacketTakePromotionRewardScRsp(Retcode retcode, List<March7thHoney.Proto.Item>? rewards = null)
		: base(307)
	{
		TakePromotionRewardScRsp takePromotionRewardScRsp = new TakePromotionRewardScRsp
		{
			Retcode = (uint)retcode
		};
		if (retcode == Retcode.RetSucc)
		{
			takePromotionRewardScRsp.RewardList = new ItemList();
			if (rewards != null)
			{
				takePromotionRewardScRsp.RewardList.ItemList_.AddRange(rewards);
			}
		}
		SetData(takePromotionRewardScRsp);
	}
}
