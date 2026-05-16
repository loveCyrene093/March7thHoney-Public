using System.Linq;
using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Shop;

public class PacketGetShopListScRsp : BasePacket
{
	public PacketGetShopListScRsp(uint shopType)
		: base(1510)
	{
		GetShopListScRsp getShopListScRsp = new GetShopListScRsp
		{
			ShopType = shopType
		};
		foreach (ShopConfigExcel value in GameData.ShopConfigData.Values)
		{
			if (value.ShopType == shopType && value.Goods.Count > 0)
			{
				getShopListScRsp.ShopList.Add(new March7thHoney.Proto.Shop
				{
					ShopId = (uint)value.ShopID,
					CityLevel = 1u,
					EndTime = 4294967295L,
					GoodsList = { from g in value.Goods
						where g.ItemID != 0
						select g.ToProto() }
				});
			}
		}
		SetData(getShopListScRsp);
	}
}
