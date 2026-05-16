using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum ChatType
{
	[OriginalName("CHAT_TYPE_NONE")]
	None,
	[OriginalName("CHAT_TYPE_PRIVATE")]
	Private,
	[OriginalName("CHAT_TYPE_GROUP")]
	Group
}
