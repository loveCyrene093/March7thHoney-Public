using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdPamSkinType
{
	[OriginalName("KCDBONKPLPC_PCPDHELPKEM")]
	KcdbonkplpcPcpdhelpkem = 0,
	[OriginalName("CmdSelectPamSkinCsReq")]
	CmdSelectPamSkinCsReq = 8122,
	[OriginalName("CmdGetPamSkinDataScRsp")]
	CmdGetPamSkinDataScRsp = 8140,
	[OriginalName("CmdSelectPamSkinScRsp")]
	CmdSelectPamSkinScRsp = 8130,
	[OriginalName("CmdGetPamSkinDataCsReq")]
	CmdGetPamSkinDataCsReq = 8121,
	[OriginalName("CmdUnlockPamSkinScNotify")]
	CmdUnlockPamSkinScNotify = 8135
}
