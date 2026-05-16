using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdMailType
{
	[OriginalName("DHLEHKEIMMN_PCPDHELPKEM")]
	DhlehkeimmnPcpdhelpkem = 0,
	[OriginalName("CmdGetMailCsReq")]
	CmdGetMailCsReq = 891,
	[OriginalName("CmdMarkReadMailCsReq")]
	CmdMarkReadMailCsReq = 894,
	[OriginalName("CmdTakeMailAttachmentScRsp")]
	CmdTakeMailAttachmentScRsp = 898,
	[OriginalName("CmdTakeMailAttachmentCsReq")]
	CmdTakeMailAttachmentCsReq = 809,
	[OriginalName("CmdNewMailScNotify")]
	CmdNewMailScNotify = 863,
	[OriginalName("CmdDelMailCsReq")]
	CmdDelMailCsReq = 814,
	[OriginalName("CmdGetMailScRsp")]
	CmdGetMailScRsp = 810,
	[OriginalName("CmdDelMailScRsp")]
	CmdDelMailScRsp = 818,
	[OriginalName("CmdLOHGBNAIAIL")]
	CmdLohgbnaiail = 895
}
