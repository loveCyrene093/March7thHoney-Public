using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdFightActivityType
{
	[OriginalName("NACBOEPEICM_PCPDHELPKEM")]
	NacboepeicmPcpdhelpkem = 0,
	[OriginalName("CmdTakeFightActivityRewardScRsp")]
	CmdTakeFightActivityRewardScRsp = 3609,
	[OriginalName("CmdTakeFightActivityRewardCsReq")]
	CmdTakeFightActivityRewardCsReq = 3618,
	[OriginalName("CmdGetFightActivityDataCsReq")]
	CmdGetFightActivityDataCsReq = 3691,
	[OriginalName("CmdGetFightActivityDataScRsp")]
	CmdGetFightActivityDataScRsp = 3610,
	[OriginalName("CmdEnterFightActivityStageCsReq")]
	CmdEnterFightActivityStageCsReq = 3695,
	[OriginalName("CmdEnterFightActivityStageScRsp")]
	CmdEnterFightActivityStageScRsp = 3614,
	[OriginalName("CmdFightActivityDataChangeScNotify")]
	CmdFightActivityDataChangeScNotify = 3694
}
