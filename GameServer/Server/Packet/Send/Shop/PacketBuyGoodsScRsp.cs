using System.Collections.Generic;
using System.Linq;
using March7thHoney.Database.Inventory;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Shop;

public class PacketBuyGoodsScRsp : BasePacket
{
	public PacketBuyGoodsScRsp(BuyGoodsCsReq req, List<ItemData> items)
		: base(1595)
	{
		BuyGoodsScRsp data = new BuyGoodsScRsp
		{
			ShopId = req.ShopId,
			GoodsBuyTimes = req.GoodsNum,
			GoodsId = req.GoodsId,
			ReturnItemList = new ItemList
			{
				ItemList_ = { items.Select((ItemData item) => item.ToProto()) }
			}
		};
		SetData(data);
	}
}
