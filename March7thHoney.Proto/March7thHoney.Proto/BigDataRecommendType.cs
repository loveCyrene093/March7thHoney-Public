using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum BigDataRecommendType
{
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_NONE")]
	None,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_EQUIPMENT")]
	Equipment,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_RELIC_SUIT")]
	RelicSuit,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_RELIC_AVATAR")]
	RelicAvatar,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_AVATAR_RELIC")]
	AvatarRelic,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_LOCAL_LEGEND")]
	LocalLegend,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_CHALLENGE_PEAK_MOB")]
	ChallengePeakMob,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_CHALLENGE_PEAK_BOSS")]
	ChallengePeakBoss,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_CHALLENGE")]
	Challenge,
	[OriginalName("BIG_DATA_RECOMMEND_TYPE_HMFFBIANKBF")]
	Hmffbiankbf
}
