using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum MsgType
{
	[OriginalName("MSG_TYPE_NONE")]
	None,
	[OriginalName("MSG_TYPE_CUSTOM_TEXT")]
	CustomText,
	[OriginalName("MSG_TYPE_EMOJI")]
	Emoji,
	[OriginalName("MSG_TYPE_INVITE")]
	Invite,
	[OriginalName("MSG_TYPE_PLANET_FES")]
	PlanetFes,
	[OriginalName("MSG_TYPE_ACIELMOLELB")]
	Acielmolelb,
	[OriginalName("MSG_TYPE_BGDMLGDMDIF")]
	Bgdmlgdmdif,
	[OriginalName("MSG_TYPE_MGLPLOPECGJ")]
	Mglplopecgj,
	[OriginalName("MSG_TYPE_PPGBFMOGAHC")]
	Ppgbfmogahc,
	[OriginalName("MSG_TYPE_BAEKHOHLLKJ")]
	Baekhohllkj
}
