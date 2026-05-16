using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.RollShop;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.RollShop;

[Opcode(6901)]
public class HandlerGetRollShopInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetRollShopInfoCsReq getRollShopInfoCsReq = GetRollShopInfoCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetRollShopInfoScRsp(getRollShopInfoCsReq.RollShopId));
	}
}
