using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum BattleRecordType
{
	[OriginalName("BATTLE_RECORD_NONE")]
	BattleRecordNone,
	[OriginalName("BATTLE_RECORD_CHALLENGE")]
	BattleRecordChallenge,
	[OriginalName("BATTLE_RECORD_ROGUE")]
	BattleRecordRogue
}
