using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Gacha;

namespace March7thHoney.GameServer.Server.Packet.Recv.Gacha;

[Opcode(1991)]
public class HandlerGetGachaInfoCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetGachaInfoScRsp(connection.Player));
	}
}
