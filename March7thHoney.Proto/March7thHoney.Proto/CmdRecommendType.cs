using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdRecommendType
{
	[OriginalName("KEHJMOOMBBA_PCPDHELPKEM")]
	KehjmoombbaPcpdhelpkem = 0,
	[OriginalName("CmdGetBigDataRecommendCsReq")]
	CmdGetBigDataRecommendCsReq = 2405,
	[OriginalName("CmdGetBigDataAllRecommendScRsp")]
	CmdGetBigDataAllRecommendScRsp = 2419,
	[OriginalName("CmdGetBigDataRecommendScRsp")]
	CmdGetBigDataRecommendScRsp = 2401,
	[OriginalName("CmdGetBigDataAllRecommendCsReq")]
	CmdGetBigDataAllRecommendCsReq = 2447
}
