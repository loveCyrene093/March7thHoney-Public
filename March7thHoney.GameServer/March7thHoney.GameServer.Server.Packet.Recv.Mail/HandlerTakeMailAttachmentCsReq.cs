using System.Collections.Generic;
using System.Threading.Tasks;
using March7thHoney.GameServer.Game.Mail;
using March7thHoney.GameServer.Server.Packet.Send.Mail;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Recv.Mail;

[Opcode(809)]
public class HandlerTakeMailAttachmentCsReq : Handler
{
	public override async Task OnHandle(Connection connection, byte[] header, byte[] data)
	{
		TakeMailAttachmentCsReq takeMailAttachmentCsReq = TakeMailAttachmentCsReq.Parser.ParseFrom(data);
		MailManager mailManager = connection.Player.MailManager;
		IEnumerable<uint> enumerable;
		if (takeMailAttachmentCsReq.MailIdList.Count <= 0)
		{
			IEnumerable<uint> mailIdsWithAttachments = mailManager.GetMailIdsWithAttachments();
			enumerable = mailIdsWithAttachments;
		}
		else
		{
			IEnumerable<uint> mailIdsWithAttachments = takeMailAttachmentCsReq.MailIdList;
			enumerable = mailIdsWithAttachments;
		}
		IEnumerable<uint> mailIds = enumerable;
		await connection.SendPacket(new PacketTakeMailAttachmentScRsp(await mailManager.TakeAttachments(mailIds)));
	}
}
