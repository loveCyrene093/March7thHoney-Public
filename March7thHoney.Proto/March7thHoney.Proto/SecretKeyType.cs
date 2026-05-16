using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum SecretKeyType
{
	[OriginalName("SECRET_KEY_NONE")]
	SecretKeyNone,
	[OriginalName("SECRET_KEY_SERVER_CHECK")]
	SecretKeyServerCheck,
	[OriginalName("SECRET_KEY_VIDEO")]
	SecretKeyVideo,
	[OriginalName("SECRET_KEY_BATTLE_TIME")]
	SecretKeyBattleTime
}
