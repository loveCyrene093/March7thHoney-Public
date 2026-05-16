using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdBattlePassType
{
	[OriginalName("FGHAGLLOPGH_PCPDHELPKEM")]
	FghagllopghPcpdhelpkem = 0,
	[OriginalName("CmdBattlePassInfoNotify")]
	CmdBattlePassInfoNotify = 3091,
	[OriginalName("CmdTakeBpRewardCsReq")]
	CmdTakeBpRewardCsReq = 3095,
	[OriginalName("CmdTakeBpRewardScRsp")]
	CmdTakeBpRewardScRsp = 3014,
	[OriginalName("CmdTakeAllRewardScRsp")]
	CmdTakeAllRewardScRsp = 3063,
	[OriginalName("CmdTakeAllRewardCsReq")]
	CmdTakeAllRewardCsReq = 3098,
	[OriginalName("CmdBuyBpLevelScRsp")]
	CmdBuyBpLevelScRsp = 3009,
	[OriginalName("CmdBuyBpLevelCsReq")]
	CmdBuyBpLevelCsReq = 3018
}
