using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum AddAvatarSrcState
{
	[OriginalName("ADD_AVATAR_SRC_NONE")]
	AddAvatarSrcNone,
	[OriginalName("ADD_AVATAR_SRC_GACHA")]
	AddAvatarSrcGacha,
	[OriginalName("ADD_AVATAR_SRC_ROGUE")]
	AddAvatarSrcRogue,
	[OriginalName("ADD_AVATAR_SRC_DELIVERY")]
	AddAvatarSrcDelivery
}
