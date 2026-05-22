using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdPamMissionType
{
	[OriginalName("PBMDIDPANOI_PCPDHELPKEM")]
	PbmdidpanoiPcpdhelpkem = 0,
	[OriginalName("CmdOLLNKPHMEPH")]
	CmdOllnkphmeph = 4010,
	[OriginalName("CmdSyncAcceptedPamMissionNotify")]
	CmdSyncAcceptedPamMissionNotify = 4094,
	[OriginalName("CmdAcceptedPamMissionExpireCsReq")]
	CmdAcceptedPamMissionExpireCsReq = 4091
}
