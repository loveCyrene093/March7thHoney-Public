using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum EnterSceneReason
{
	[OriginalName("ENTER_SCENE_REASON_NONE")]
	None,
	[OriginalName("ENTER_SCENE_REASON_CHALLENGE_TIMEOUT")]
	ChallengeTimeout,
	[OriginalName("ENTER_SCENE_REASON_ROGUE_TIMEOUT")]
	RogueTimeout,
	[OriginalName("ENTER_SCENE_REASON_CHANGE_STORYLINE")]
	ChangeStoryline,
	[OriginalName("ENTER_SCENE_REASON_DIMENSION_MERGE")]
	DimensionMerge
}
