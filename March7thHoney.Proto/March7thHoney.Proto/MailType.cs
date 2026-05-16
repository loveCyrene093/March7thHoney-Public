using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum MailType
{
	[OriginalName("MAIL_TYPE_NORMAL")]
	Normal,
	[OriginalName("MAIL_TYPE_STAR")]
	Star
}
