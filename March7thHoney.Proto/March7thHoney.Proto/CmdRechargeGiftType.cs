using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdRechargeGiftType
{
	[OriginalName("FKKDLKJDPAL_PCPDHELPKEM")]
	FkkdlkjdpalPcpdhelpkem = 0,
	[OriginalName("CmdSyncRechargeBenefitInfoScNotify")]
	CmdSyncRechargeBenefitInfoScNotify = 8374,
	[OriginalName("CmdTakeRechargeBenefitRewardCsReq")]
	CmdTakeRechargeBenefitRewardCsReq = 8377,
	[OriginalName("CmdTakeRechargeGiftRewardScRsp")]
	CmdTakeRechargeGiftRewardScRsp = 8370,
	[OriginalName("CmdGetRechargeBenefitInfoScRsp")]
	CmdGetRechargeBenefitInfoScRsp = 8368,
	[OriginalName("CmdGetRechargeGiftInfoScRsp")]
	CmdGetRechargeGiftInfoScRsp = 8380,
	[OriginalName("CmdGetRechargeBenefitInfoCsReq")]
	CmdGetRechargeBenefitInfoCsReq = 8375,
	[OriginalName("CmdGetRechargeGiftInfoCsReq")]
	CmdGetRechargeGiftInfoCsReq = 8361,
	[OriginalName("CmdTakeRechargeBenefitRewardScRsp")]
	CmdTakeRechargeBenefitRewardScRsp = 8367,
	[OriginalName("CmdTakeRechargeGiftRewardCsReq")]
	CmdTakeRechargeGiftRewardCsReq = 8362
}
