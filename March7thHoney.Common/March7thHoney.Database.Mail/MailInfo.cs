using March7thHoney.Proto;

namespace March7thHoney.Database.Mail;

public class MailInfo
{
	public int MailID { get; set; }

	public string SenderName { get; set; } = "";

	public string Title { get; set; } = "";

	public string Content { get; set; } = "";

	public bool IsRead { get; set; }

	public bool IsStar { get; set; }

	public long SendTime { get; set; }

	public long ExpireTime { get; set; }

	public int TemplateID { get; set; }

	public MailAttachmentInfo Attachment { get; set; } = new MailAttachmentInfo();

	public ClientMail ToProto()
	{
		return new ClientMail
		{
			Id = (uint)MailID,
			Sender = SenderName,
			Content = Content,
			MailType = (IsStar ? MailType.Star : MailType.Normal),
			ExpireTime = ExpireTime,
			IsRead = IsRead,
			TemplateId = (uint)TemplateID,
			Title = Title,
			Time = SendTime,
			Attachment = Attachment.ToProto()
		};
	}
}
