using System.Threading.Tasks;
using March7thHoney.Database.Mail;
using March7thHoney.GameServer.Server.Packet.Send.Mail;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mail;

[Opcode(894)]
public class HandlerMarkReadMailCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		MarkReadMailCsReq markReadMailCsReq = MarkReadMailCsReq.Parser.ParseFrom(data);
		MailInfo mail = connection.Player.MailManager.GetMail((int)markReadMailCsReq.Id);
		if (mail != null)
		{
			mail.IsRead = true;
			await connection.SendPacket(new PacketMarkReadMailScRsp(markReadMailCsReq.Id));
		}
		else
		{
			await connection.SendPacket(new PacketMarkReadMailScRsp(Retcode.RetMailMailIdInvalid));
		}
	}
}
