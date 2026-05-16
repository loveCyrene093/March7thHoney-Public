using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Quest;

public class PacketTakeQuestRewardScRsp : BasePacket
{
	public PacketTakeQuestRewardScRsp(Retcode retCode, List<ItemData> items, List<int> succQuestIds)
		: base(995)
	{
		TakeQuestRewardScRsp data = new TakeQuestRewardScRsp
		{
			Retcode = (uint)retCode,
			Reward = new ItemList
			{
				ItemList_ = { items.Select((ItemData x) => x.ToProto()) }
			},
			SuccQuestIdList = { succQuestIds.Select((int x) => (uint)x) }
		};
		SetData(data);
	}
}
