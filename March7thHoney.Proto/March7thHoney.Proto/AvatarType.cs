using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum AvatarType
{
	[OriginalName("AVATAR_TYPE_NONE")]
	None,
	[OriginalName("AVATAR_TRIAL_TYPE")]
	AvatarTrialType,
	[OriginalName("AVATAR_LIMIT_TYPE")]
	AvatarLimitType,
	[OriginalName("AVATAR_FORMAL_TYPE")]
	AvatarFormalType,
	[OriginalName("AVATAR_ASSIST_TYPE")]
	AvatarAssistType,
	[OriginalName("AVATAR_AETHER_DIVIDE_TYPE")]
	AvatarAetherDivideType,
	[OriginalName("AVATAR_UPGRADE_AVAILABLE_TYPE")]
	AvatarUpgradeAvailableType,
	[OriginalName("AVATAR_GRID_FIGHT_TYPE")]
	AvatarGridFightType,
	[OriginalName("AVATAR_GLJDNDMIGIP")]
	AvatarGljdndmigip
}
