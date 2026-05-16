using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Avatar;

public class PacketTakePromotionRewardScRsp : BasePacket
{
	public PacketTakePromotionRewardScRsp()
		: base(307)
	{
		March7thHoney.Proto.Item item = new March7thHoney.Proto.Item
		{
			ItemId = 101u,
			Num = 1u
		};
		TakePromotionRewardScRsp data = new TakePromotionRewardScRsp
		{
			RewardList = new ItemList
			{
				ItemList_ = { item }
			}
		};
		SetData(data);
	}
}
