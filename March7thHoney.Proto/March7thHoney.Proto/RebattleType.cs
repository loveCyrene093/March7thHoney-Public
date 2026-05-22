using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum RebattleType
{
	[OriginalName("REBATTLE_TYPE_NONE")]
	None,
	[OriginalName("REBATTLE_TYPE_REBATTLE_MIDWAY")]
	RebattleMidway,
	[OriginalName("REBATTLE_TYPE_REBATTLE_LOSE")]
	RebattleLose,
	[OriginalName("REBATTLE_TYPE_REBATTLE_MIDWAY_LINEUP")]
	RebattleMidwayLineup,
	[OriginalName("REBATTLE_TYPE_REBATTLE_LOSE_LINEUP")]
	RebattleLoseLineup,
	[OriginalName("REBATTLE_TYPE_QUIT_MIDWAY")]
	QuitMidway,
	[OriginalName("REBATTLE_TYPE_QUIT_LOSE")]
	QuitLose
}
