using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum GameplayCounterType
{
	[OriginalName("GAMEPLAY_COUNTER_NONE")]
	GameplayCounterNone = 0,
	[OriginalName("GAMEPLAY_COUNTER_MONSTER_SNEAK_VISION")]
	GameplayCounterMonsterSneakVision = 280001
}
