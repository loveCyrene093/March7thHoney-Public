using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Archive;

namespace March7thHoney.GameServer.Server.Packet.Recv.Archive;

[Opcode(2391)]
public class HandlerGetArchiveDataCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetArchiveDataScRsp(connection.Player));
	}
}
