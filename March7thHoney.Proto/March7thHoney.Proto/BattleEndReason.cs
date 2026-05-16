using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum BattleEndReason
{
	[OriginalName("BATTLE_END_REASON_NONE")]
	None,
	[OriginalName("BATTLE_END_REASON_ALL_DIE")]
	AllDie,
	[OriginalName("BATTLE_END_REASON_TURN_LIMIT")]
	TurnLimit
}
