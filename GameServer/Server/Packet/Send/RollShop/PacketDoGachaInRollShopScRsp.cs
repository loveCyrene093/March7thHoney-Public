using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.RollShop;

public class PacketDoGachaInRollShopScRsp : BasePacket
{
	public PacketDoGachaInRollShopScRsp(uint RollShopId, ItemList reward, uint type)
		: base(6910)
	{
		SetData(new DoGachaInRollShopScRsp
		{
			RollShopId = RollShopId,
			RewardDisplayType = type,
			Reward = reward
		});
	}
}
