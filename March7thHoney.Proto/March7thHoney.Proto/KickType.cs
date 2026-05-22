using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum KickType
{
	[OriginalName("KICK_SQUEEZED")]
	KickSqueezed,
	[OriginalName("KICK_BLACK")]
	KickBlack,
	[OriginalName("KICK_CHANGE_PWD")]
	KickChangePwd,
	[OriginalName("KICK_LOGIN_WHITE_TIMEOUT")]
	KickLoginWhiteTimeout,
	[OriginalName("KICK_ACE_ANTI_CHEATER")]
	KickAceAntiCheater,
	[OriginalName("KICK_BY_GM")]
	KickByGm
}
