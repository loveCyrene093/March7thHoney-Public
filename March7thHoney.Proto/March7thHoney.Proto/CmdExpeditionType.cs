using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdExpeditionType
{
	[OriginalName("FJKMDGNDILO_PCPDHELPKEM")]
	FjkmdgndiloPcpdhelpkem = 0,
	[OriginalName("CmdAcceptMultipleExpeditionCsReq")]
	CmdAcceptMultipleExpeditionCsReq = 2503,
	[OriginalName("CmdAcceptMultipleExpeditionScRsp")]
	CmdAcceptMultipleExpeditionScRsp = 2550,
	[OriginalName("CmdTakeMultipleExpeditionRewardCsReq")]
	CmdTakeMultipleExpeditionRewardCsReq = 2516,
	[OriginalName("CmdGetExpeditionDataCsReq")]
	CmdGetExpeditionDataCsReq = 2513,
	[OriginalName("CmdTakeMultipleExpeditionRewardScRsp")]
	CmdTakeMultipleExpeditionRewardScRsp = 2531,
	[OriginalName("CmdGAJMDNEKPOP")]
	CmdGajmdnekpop = 2547,
	[OriginalName("CmdGetExpeditionDataScRsp")]
	CmdGetExpeditionDataScRsp = 2507
}
