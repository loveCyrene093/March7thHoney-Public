using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum MonsterBattleType
{
	[OriginalName("MONSTER_BATTLE_TYPE_NONE")]
	None,
	[OriginalName("MONSTER_BATTLE_TYPE_TRIGGER_BATTLE")]
	TriggerBattle,
	[OriginalName("MONSTER_BATTLE_TYPE_DIRECT_DIE_SIMULATE_BATTLE")]
	DirectDieSimulateBattle,
	[OriginalName("MONSTER_BATTLE_TYPE_DIRECT_DIE_SKIP_BATTLE")]
	DirectDieSkipBattle,
	[OriginalName("MONSTER_BATTLE_TYPE_NO_BATTLE")]
	NoBattle
}
