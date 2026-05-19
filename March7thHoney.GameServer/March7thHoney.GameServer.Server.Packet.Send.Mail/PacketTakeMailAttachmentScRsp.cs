using System.Collections.Generic;
using System.Linq;
using March7thHoney.GameServer.Game.Mail;
using March7thHoney.Kcp;
using March7thHoney.Proto;

namespace March7thHoney.GameServer.Server.Packet.Send.Mail;

public class PacketTakeMailAttachmentScRsp : BasePacket
{
	public PacketTakeMailAttachmentScRsp(TakeMailAttachmentResult result)
		: base(898)
	{
		TakeMailAttachmentScRsp data = new TakeMailAttachmentScRsp
		{
			Attachment = result.Attachment.ToProto(),
			SuccMailIdList = { (IEnumerable<uint>)result.SuccessMailIds },
			FailMailList = { result.FailedMails.Select((TakeMailAttachmentFailInfo mail) => new KEOAIHACHKG
			{
				ItemId = mail.MailId,
				LPCPBEIHFMK = (uint)mail.Retcode
			}) }
		};
		SetData(data);
	}
}
