using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdDailyActiveType
{
	[OriginalName("OMDDKHBJBGE_PCPDHELPKEM")]
	OmddkhbjbgePcpdhelpkem = 0,
	[OriginalName("CmdTakeApRewardScRsp")]
	CmdTakeApRewardScRsp = 3310,
	[OriginalName("CmdDailyActiveInfoNotify")]
	CmdDailyActiveInfoNotify = 3314,
	[OriginalName("CmdTakeApRewardCsReq")]
	CmdTakeApRewardCsReq = 3391,
	[OriginalName("CmdGetDailyActiveInfoCsReq")]
	CmdGetDailyActiveInfoCsReq = 3394,
	[OriginalName("CmdTakeAllApRewardCsReq")]
	CmdTakeAllApRewardCsReq = 3318,
	[OriginalName("CmdTakeAllApRewardScRsp")]
	CmdTakeAllApRewardScRsp = 3309,
	[OriginalName("CmdGetDailyActiveInfoScRsp")]
	CmdGetDailyActiveInfoScRsp = 3395
}
