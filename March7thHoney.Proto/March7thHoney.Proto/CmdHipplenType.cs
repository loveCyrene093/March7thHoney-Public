using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdHipplenType
{
	[OriginalName("OBJLNOCFBIO_PCPDHELPKEM")]
	ObjlnocfbioPcpdhelpkem = 0,
	[OriginalName("CmdSetHipplenOutfitCsReq")]
	CmdSetHipplenOutfitCsReq = 9018,
	[OriginalName("CmdTakeHipplenEndingRewardCsReq")]
	CmdTakeHipplenEndingRewardCsReq = 9016,
	[OriginalName("CmdGetHipplenInheritScRsp")]
	CmdGetHipplenInheritScRsp = 9027,
	[OriginalName("CmdGetHipplenInheritCsReq")]
	CmdGetHipplenInheritCsReq = 9030,
	[OriginalName("CmdHipplenTraitUnlockScNotify")]
	CmdHipplenTraitUnlockScNotify = 9050,
	[OriginalName("CmdSetHipplenAgendaCsReq")]
	CmdSetHipplenAgendaCsReq = 9035,
	[OriginalName("CmdSettleHipplenWorkCsReq")]
	CmdSettleHipplenWorkCsReq = 9005,
	[OriginalName("CmdOpenHipplenCycleScRsp")]
	CmdOpenHipplenCycleScRsp = 9044,
	[OriginalName("CmdHipplenAgendaResultScNotify")]
	CmdHipplenAgendaResultScNotify = 9047,
	[OriginalName("CmdGetHipplenDataCsReq")]
	CmdGetHipplenDataCsReq = 9013,
	[OriginalName("CmdSettleHipplenWorkScRsp")]
	CmdSettleHipplenWorkScRsp = 9001,
	[OriginalName("CmdGetHipplenDataScRsp")]
	CmdGetHipplenDataScRsp = 9007,
	[OriginalName("CmdHipplenCycleResultScNotify")]
	CmdHipplenCycleResultScNotify = 9019,
	[OriginalName("CmdSetHipplenOutfitScRsp")]
	CmdSetHipplenOutfitScRsp = 9045,
	[OriginalName("CmdSetHipplenAgendaScRsp")]
	CmdSetHipplenAgendaScRsp = 9038,
	[OriginalName("CmdTakeHipplenEndingRewardScRsp")]
	CmdTakeHipplenEndingRewardScRsp = 9031,
	[OriginalName("CmdHipplenChangeScNotify")]
	CmdHipplenChangeScNotify = 9021,
	[OriginalName("CmdOpenHipplenCycleCsReq")]
	CmdOpenHipplenCycleCsReq = 9002
}
