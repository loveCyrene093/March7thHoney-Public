using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Mail;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mail;

[Opcode(891)]
public class HandlerGetMailCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		GetMailCsReq getMailCsReq = GetMailCsReq.Parser.ParseFrom(data);
		await connection.SendPacket(new PacketGetMailScRsp(connection.Player, getMailCsReq.DDLPGNHADCJ, getMailCsReq.FHGKLJEHIGA));
	}
}
