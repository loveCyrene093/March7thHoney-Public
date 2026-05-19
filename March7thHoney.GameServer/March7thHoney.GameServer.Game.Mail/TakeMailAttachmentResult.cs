using System.Collections.Generic;
using March7thHoney.Database.Mail;

namespace March7thHoney.GameServer.Game.Mail;

public class TakeMailAttachmentResult
{
	public MailAttachmentInfo Attachment { get; } = new MailAttachmentInfo();

	public List<uint> SuccessMailIds { get; } = new List<uint>();

	public List<TakeMailAttachmentFailInfo> FailedMails { get; } = new List<TakeMailAttachmentFailInfo>();
}
