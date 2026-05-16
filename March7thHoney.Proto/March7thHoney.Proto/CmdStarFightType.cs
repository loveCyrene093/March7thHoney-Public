using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdStarFightType
{
	[OriginalName("JHPDEBBIDMN_PCPDHELPKEM")]
	JhpdebbidmnPcpdhelpkem = 0,
	[OriginalName("CmdGetStarFightDataScRsp")]
	CmdGetStarFightDataScRsp = 7170,
	[OriginalName("CmdStartStarFightLevelScRsp")]
	CmdStartStarFightLevelScRsp = 7167,
	[OriginalName("CmdStarFightDataChangeNotify")]
	CmdStarFightDataChangeNotify = 7165,
	[OriginalName("CmdGetStarFightDataCsReq")]
	CmdGetStarFightDataCsReq = 7169,
	[OriginalName("CmdStartStarFightLevelCsReq")]
	CmdStartStarFightLevelCsReq = 7161
}
