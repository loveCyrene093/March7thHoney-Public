using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum QuestStatus
{
	[OriginalName("QUEST_NONE")]
	QuestNone,
	[OriginalName("QUEST_DOING")]
	QuestDoing,
	[OriginalName("QUEST_FINISH")]
	QuestFinish,
	[OriginalName("QUEST_CLOSE")]
	QuestClose,
	[OriginalName("QUEST_DELETE")]
	QuestDelete
}
