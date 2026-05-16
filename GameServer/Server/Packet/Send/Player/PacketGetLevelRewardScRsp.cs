using System.Collections.Generic;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketGetLevelRewardScRsp : BasePacket
{
	public PacketGetLevelRewardScRsp(uint level, List<ItemData> reward)
		: base(89)
	{
		GetLevelRewardScRsp getLevelRewardScRsp = new GetLevelRewardScRsp
		{
			Level = level,
			Reward = new ItemList()
		};
		foreach (ItemData item in reward)
		{
			getLevelRewardScRsp.Reward.ItemList_.Add(item.ToProto());
		}
		SetData(getLevelRewardScRsp);
	}

	public PacketGetLevelRewardScRsp(Retcode retCode)
		: base(89)
	{
		GetLevelRewardScRsp data = new GetLevelRewardScRsp
		{
			Retcode = (uint)retCode
		};
		SetData(data);
	}
}
