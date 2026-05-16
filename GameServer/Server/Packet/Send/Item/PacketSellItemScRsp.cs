using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Item;

public class PacketSellItemScRsp : BasePacket
{
	public PacketSellItemScRsp(List<ItemData> items)
		: base(561)
	{
		SellItemScRsp data = new SellItemScRsp
		{
			ReturnItemList = new ItemList
			{
				ItemList_ = { items.Select((ItemData x) => x.ToProto()) }
			}
		};
		SetData(data);
	}
}
