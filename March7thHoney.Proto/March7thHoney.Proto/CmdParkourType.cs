using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdParkourType
{
	[OriginalName("PCHEOAIBEKK_PCPDHELPKEM")]
	PcheoaibekkPcpdhelpkem = 0,
	[OriginalName("CmdParkourGetRankingInfoCsReq")]
	CmdParkourGetRankingInfoCsReq = 8382,
	[OriginalName("CmdParkourGetDataScRsp")]
	CmdParkourGetDataScRsp = 8400,
	[OriginalName("CmdParkourStartLevelScRsp")]
	CmdParkourStartLevelScRsp = 8388,
	[OriginalName("CmdParkourEndLevelScRsp")]
	CmdParkourEndLevelScRsp = 8397,
	[OriginalName("CmdParkourGetDataCsReq")]
	CmdParkourGetDataCsReq = 8381,
	[OriginalName("CmdParkourStartLevelCsReq")]
	CmdParkourStartLevelCsReq = 8395,
	[OriginalName("CmdParkourEndLevelCsReq")]
	CmdParkourEndLevelCsReq = 8394,
	[OriginalName("CmdParkourGetRankingInfoScRsp")]
	CmdParkourGetRankingInfoScRsp = 8390
}
