using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum AreaType
{
	[OriginalName("AREA_NONE")]
	AreaNone,
	[OriginalName("AREA_CN")]
	AreaCn,
	[OriginalName("AREA_JP")]
	AreaJp,
	[OriginalName("AREA_ASIA")]
	AreaAsia,
	[OriginalName("AREA_WEST")]
	AreaWest,
	[OriginalName("AREA_KR")]
	AreaKr,
	[OriginalName("AREA_OVERSEAS")]
	AreaOverseas
}
