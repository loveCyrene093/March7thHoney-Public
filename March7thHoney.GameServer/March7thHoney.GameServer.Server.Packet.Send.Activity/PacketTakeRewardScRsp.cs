using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Activity;

public class PacketTakeRewardScRsp : BasePacket
{
	public PacketTakeRewardScRsp()
		: base(2668)
	{
		TakeRewardScRsp data = new TakeRewardScRsp
		{
			Retcode = 0u,
			Reward = new ItemList
			{
				ItemList_ = 
				{
					new March7thHoney.Proto.Item
					{
						ItemId = 1u,
						Num = 1600u
					},
					new March7thHoney.Proto.Item
					{
						ItemId = 201u,
						Num = 10u
					}
				}
			}
		};
		SetData(data);
	}
}
