using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum MessageSectionStatus
{
	[OriginalName("MESSAGE_SECTION_NONE")]
	MessageSectionNone,
	[OriginalName("MESSAGE_SECTION_DOING")]
	MessageSectionDoing,
	[OriginalName("MESSAGE_SECTION_FINISH")]
	MessageSectionFinish,
	[OriginalName("MESSAGE_SECTION_FROZEN")]
	MessageSectionFrozen
}
