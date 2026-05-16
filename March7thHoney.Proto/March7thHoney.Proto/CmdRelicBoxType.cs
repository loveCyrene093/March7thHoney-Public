using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdRelicBoxType
{
	[OriginalName("EOICCPKPFPB_PCPDHELPKEM")]
	EoiccpkpfpbPcpdhelpkem = 0,
	[OriginalName("CmdSetRelicBoxTargetScRsp")]
	CmdSetRelicBoxTargetScRsp = 8958,
	[OriginalName("CmdSetRelicBoxCustomCsReq")]
	CmdSetRelicBoxCustomCsReq = 8952,
	[OriginalName("CmdSetRelicBoxCustomScRsp")]
	CmdSetRelicBoxCustomScRsp = 8960,
	[OriginalName("CmdRelicBoxRegularScNotify")]
	CmdRelicBoxRegularScNotify = 8963,
	[OriginalName("CmdSetRelicBoxTargetCsReq")]
	CmdSetRelicBoxTargetCsReq = 8965,
	[OriginalName("CmdConfirmRelicBoxScRsp")]
	CmdConfirmRelicBoxScRsp = 8968,
	[OriginalName("CmdConfirmRelicBoxCsReq")]
	CmdConfirmRelicBoxCsReq = 8961,
	[OriginalName("CmdOpenRelicBoxScRsp")]
	CmdOpenRelicBoxScRsp = 8969,
	[OriginalName("CmdOpenRelicBoxCsReq")]
	CmdOpenRelicBoxCsReq = 8957,
	[OriginalName("CmdGetRelicBoxDataScRsp")]
	CmdGetRelicBoxDataScRsp = 8970,
	[OriginalName("CmdReportRelicBoxActionScRsp")]
	CmdReportRelicBoxActionScRsp = 8959,
	[OriginalName("CmdGetRelicBoxDataCsReq")]
	CmdGetRelicBoxDataCsReq = 8951,
	[OriginalName("CmdReportRelicBoxActionCsReq")]
	CmdReportRelicBoxActionCsReq = 8953
}
