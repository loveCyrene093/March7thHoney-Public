using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Message;

namespace March7thHoney.GameServer.Server.Packet.Recv.Message;

[Opcode(2794)]
public class HandlerGetNpcStatusCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetNpcStatusScRsp(connection.Player));
	}
}
