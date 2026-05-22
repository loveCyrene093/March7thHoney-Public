using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdOfferingType
{
	[OriginalName("EBHGGMBCBIA_PCPDHELPKEM")]
	EbhggmbcbiaPcpdhelpkem = 0,
	[OriginalName("CmdSubmitOfferingItemScRsp")]
	CmdSubmitOfferingItemScRsp = 6930,
	[OriginalName("CmdTakeOfferingRewardScRsp")]
	CmdTakeOfferingRewardScRsp = 6928,
	[OriginalName("CmdGetOfferingInfoScRsp")]
	CmdGetOfferingInfoScRsp = 6940,
	[OriginalName("CmdOfferingInfoScNotify")]
	CmdOfferingInfoScNotify = 6934,
	[OriginalName("CmdGetOfferingInfoCsReq")]
	CmdGetOfferingInfoCsReq = 6921,
	[OriginalName("CmdTakeOfferingRewardCsReq")]
	CmdTakeOfferingRewardCsReq = 6935,
	[OriginalName("CmdSubmitOfferingItemCsReq")]
	CmdSubmitOfferingItemCsReq = 6922
}
