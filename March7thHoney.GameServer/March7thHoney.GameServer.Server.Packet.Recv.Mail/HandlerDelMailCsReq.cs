using System.Linq;
using System.Threading.Tasks;
using March7thHoney.GameServer.Server.Packet.Send.Mail;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mail;

[Opcode(814)]
public class HandlerDelMailCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		DelMailCsReq delMailCsReq = DelMailCsReq.Parser.ParseFrom(data);
		foreach (uint id in delMailCsReq.IdList)
		{
			connection.Player.MailManager?.DeleteMail((int)id);
		}
		await connection.SendPacket(new PacketDelMailScRsp(delMailCsReq.IdList.ToList()));
	}
}
