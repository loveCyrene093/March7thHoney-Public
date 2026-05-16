using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum SkillExtraTag
{
	[OriginalName("SCENE_CAST_SKILL_NONE")]
	SceneCastSkillNone,
	[OriginalName("SCENE_CAST_SKILL_PROJECTILE_HIT")]
	SceneCastSkillProjectileHit,
	[OriginalName("SCENE_CAST_SKILL_PROJECTILE_LIFETIME_FINISH")]
	SceneCastSkillProjectileLifetimeFinish
}
