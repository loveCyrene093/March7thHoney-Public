using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum MessageGroupStatus
{
	[OriginalName("MESSAGE_GROUP_NONE")]
	MessageGroupNone,
	[OriginalName("MESSAGE_GROUP_DOING")]
	MessageGroupDoing,
	[OriginalName("MESSAGE_GROUP_FINISH")]
	MessageGroupFinish,
	[OriginalName("MESSAGE_GROUP_FROZEN")]
	MessageGroupFrozen
}
