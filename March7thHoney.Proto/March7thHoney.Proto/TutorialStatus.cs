using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum TutorialStatus
{
	[OriginalName("TUTORIAL_NONE")]
	TutorialNone,
	[OriginalName("TUTORIAL_UNLOCK")]
	TutorialUnlock,
	[OriginalName("TUTORIAL_FINISH")]
	TutorialFinish
}
