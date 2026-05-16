using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Shop;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Shop;

[Opcode(1591)]
public class HandlerGetShopListCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetShopListCsReq getShopListCsReq = GetShopListCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetShopListScRsp(getShopListCsReq.ShopType));
	}
}
