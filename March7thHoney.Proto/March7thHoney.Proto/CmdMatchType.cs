using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdMatchType
{
	[OriginalName("PCGFLPCNCLM_PCPDHELPKEM")]
	PcgflpcnclmPcpdhelpkem = 0,
	[OriginalName("CmdGetCrossInfoCsReq")]
	CmdGetCrossInfoCsReq = 7338,
	[OriginalName("CmdCancelMatchCsReq")]
	CmdCancelMatchCsReq = 7330,
	[OriginalName("CmdStartMatchCsReq")]
	CmdStartMatchCsReq = 7313,
	[OriginalName("CmdAAHCMMKMENA")]
	CmdAahcmmkmena = 7307,
	[OriginalName("CmdJOLDJBKMHGA")]
	CmdJoldjbkmhga = 7327,
	[OriginalName("CmdGetCrossInfoScRsp")]
	CmdGetCrossInfoScRsp = 7305,
	[OriginalName("CmdJOEPJJKIPJC")]
	CmdJoepjjkipjc = 7335
}
