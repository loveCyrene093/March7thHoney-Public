using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Mail;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mail;

[Opcode(891)]
public class HandlerGetMailCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		await connection.SendPacket(new PacketGetMailScRsp(connection.Player));
	}
}
