using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdMessageType
{
	[OriginalName("PHLMMOJPKHA_PCPDHELPKEM")]
	PhlmmojpkhaPcpdhelpkem = 0,
	[OriginalName("CmdFinishItemIdScRsp")]
	CmdFinishItemIdScRsp = 2718,
	[OriginalName("CmdGetMissionMessageScRsp")]
	CmdGetMissionMessageScRsp = 2701,
	[OriginalName("CmdFinishPerformSectionIdScRsp")]
	CmdFinishPerformSectionIdScRsp = 2726,
	[OriginalName("CmdFinishSectionIdScRsp")]
	CmdFinishSectionIdScRsp = 2798,
	[OriginalName("CmdFinishSectionIdCsReq")]
	CmdFinishSectionIdCsReq = 2709,
	[OriginalName("CmdFinishItemIdCsReq")]
	CmdFinishItemIdCsReq = 2714,
	[OriginalName("CmdFinishPerformSectionIdCsReq")]
	CmdFinishPerformSectionIdCsReq = 2763,
	[OriginalName("CmdGetNpcStatusCsReq")]
	CmdGetNpcStatusCsReq = 2794,
	[OriginalName("CmdGetMissionMessageCsReq")]
	CmdGetMissionMessageCsReq = 2739,
	[OriginalName("CmdGetNpcMessageGroupCsReq")]
	CmdGetNpcMessageGroupCsReq = 2791,
	[OriginalName("CmdGetNpcMessageGroupScRsp")]
	CmdGetNpcMessageGroupScRsp = 2710,
	[OriginalName("CmdGetNpcStatusScRsp")]
	CmdGetNpcStatusScRsp = 2795
}
