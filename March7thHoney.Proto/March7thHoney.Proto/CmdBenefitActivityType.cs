using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdBenefitActivityType
{
	[OriginalName("DLJPALHAPPL_PCPDHELPKEM")]
	DljpalhapplPcpdhelpkem = 0,
	[OriginalName("CmdGetBenefitActivityInfo")]
	CmdGetBenefitActivityInfo = 4857,
	[OriginalName("CmdCDFGBPOPNAL")]
	CmdCdfgbpopnal = 4888,
	[OriginalName("CmdJoinBenefitActivityCsReq")]
	CmdJoinBenefitActivityCsReq = 4885,
	[OriginalName("CmdGetBenefitActivityInfoCsReq")]
	CmdGetBenefitActivityInfoCsReq = 4863,
	[OriginalName("CmdTakeBenefitActivityRewardCsReq")]
	CmdTakeBenefitActivityRewardCsReq = 4880,
	[OriginalName("CmdTakeBenefitActivityRewardScRsp")]
	CmdTakeBenefitActivityRewardScRsp = 4877
}
