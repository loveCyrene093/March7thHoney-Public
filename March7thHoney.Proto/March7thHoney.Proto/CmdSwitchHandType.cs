using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdSwitchHandType
{
	[OriginalName("INMKGNMPOED_PCPDHELPKEM")]
	InmkgnmpoedPcpdhelpkem = 0,
	[OriginalName("CmdGetSwitchHandResetHandPosScRsp")]
	CmdGetSwitchHandResetHandPosScRsp = 8118,
	[OriginalName("CmdSwitchHandResetGameCsReq")]
	CmdSwitchHandResetGameCsReq = 8104,
	[OriginalName("CmdSwitchHandStartScRsp")]
	CmdSwitchHandStartScRsp = 8110,
	[OriginalName("CmdINDKHMAOAKM")]
	CmdIndkhmaoakm = 8119,
	[OriginalName("CmdSwitchHandUpdateCsReq")]
	CmdSwitchHandUpdateCsReq = 8114,
	[OriginalName("CmdSwitchHandResetTransformCsReq")]
	CmdSwitchHandResetTransformCsReq = 8111,
	[OriginalName("CmdSwitchHandStartCsReq")]
	CmdSwitchHandStartCsReq = 8102,
	[OriginalName("CmdSwitchHandCoinUpdateCsReq")]
	CmdSwitchHandCoinUpdateCsReq = 8107,
	[OriginalName("CmdSwitchHandFinishCsReq")]
	CmdSwitchHandFinishCsReq = 8115,
	[OriginalName("CmdSwitchHandFinishScRsp")]
	CmdSwitchHandFinishScRsp = 8108,
	[OriginalName("CmdGetSwitchHandDataScRsp")]
	CmdGetSwitchHandDataScRsp = 8120,
	[OriginalName("CmdSwitchHandDataCsReq")]
	CmdSwitchHandDataCsReq = 8101,
	[OriginalName("CmdGetSwitchHandResetGameScRsp")]
	CmdGetSwitchHandResetGameScRsp = 8103,
	[OriginalName("CmdGetSwitchHandUpdateScRsp")]
	CmdGetSwitchHandUpdateScRsp = 8117
}
