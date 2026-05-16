using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum BattleEndStatus
{
	[OriginalName("BATTLE_END_NONE")]
	BattleEndNone,
	[OriginalName("BATTLE_END_WIN")]
	BattleEndWin,
	[OriginalName("BATTLE_END_LOSE")]
	BattleEndLose,
	[OriginalName("BATTLE_END_QUIT")]
	BattleEndQuit
}
