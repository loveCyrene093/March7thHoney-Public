using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum EntityType
{
	[OriginalName("ENTITY_NONE")]
	EntityNone,
	[OriginalName("ENTITY_AVATAR")]
	EntityAvatar,
	[OriginalName("ENTITY_MONSTER")]
	EntityMonster,
	[OriginalName("ENTITY_NPC")]
	EntityNpc,
	[OriginalName("ENTITY_PROP")]
	EntityProp,
	[OriginalName("ENTITY_TRIGGER")]
	EntityTrigger,
	[OriginalName("ENTITY_ENV")]
	EntityEnv,
	[OriginalName("ENTITY_SUMMON_UNIT")]
	EntitySummonUnit
}
