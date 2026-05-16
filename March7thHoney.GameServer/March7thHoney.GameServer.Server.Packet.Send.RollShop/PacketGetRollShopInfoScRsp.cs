using March7thHoney.Data;
using March7thHoney.Data.Excel;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.RollShop;

public class PacketGetRollShopInfoScRsp : BasePacket
{
	public PacketGetRollShopInfoScRsp(uint rollShopId)
		: base(6920)
	{
		GetRollShopInfoScRsp getRollShopInfoScRsp = new GetRollShopInfoScRsp
		{
			RollShopId = rollShopId,
			GachaRandom = 1u
		};
		foreach (RollShopConfigExcel value in GameData.RollShopConfigData.Values)
		{
			if (value.RollShopID == rollShopId)
			{
				getRollShopInfoScRsp.ShopGroupIdList.Add(value.T1GroupID);
				getRollShopInfoScRsp.ShopGroupIdList.Add(value.T2GroupID);
				getRollShopInfoScRsp.ShopGroupIdList.Add(value.T3GroupID);
				getRollShopInfoScRsp.ShopGroupIdList.Add(value.T4GroupID);
			}
		}
		getRollShopInfoScRsp.Retcode = 0u;
		SetData(getRollShopInfoScRsp);
	}
}
