using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Player;

public class PacketMonthCardRewardNotify : BasePacket
{
	public PacketMonthCardRewardNotify(List<ItemData> items)
		: base(59)
	{
		MonthCardRewardNotify data = new MonthCardRewardNotify
		{
			Reward = new ItemList
			{
				ItemList_ = { items.Select((ItemData x) => x.ToProto()) }
			}
		};
		SetData(data);
	}
}
