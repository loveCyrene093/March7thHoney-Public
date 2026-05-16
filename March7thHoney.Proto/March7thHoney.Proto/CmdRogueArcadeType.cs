using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdRogueArcadeType
{
	[OriginalName("JEJMOKKEGLI_PCPDHELPKEM")]
	JejmokkegliPcpdhelpkem = 0,
	[OriginalName("CmdRogueArcadeGetInfoScRsp")]
	CmdRogueArcadeGetInfoScRsp = 7677,
	[OriginalName("CmdRogueArcadeRestartCsReq")]
	CmdRogueArcadeRestartCsReq = 7681,
	[OriginalName("CmdRogueArcadeGetInfoCsReq")]
	CmdRogueArcadeGetInfoCsReq = 7651,
	[OriginalName("CmdRogueArcadeStartCsReq")]
	CmdRogueArcadeStartCsReq = 7687,
	[OriginalName("CmdRogueArcadeRestartScRsp")]
	CmdRogueArcadeRestartScRsp = 7698,
	[OriginalName("CmdRogueArcadeLeaveScRsp")]
	CmdRogueArcadeLeaveScRsp = 7655,
	[OriginalName("CmdRogueArcadeStartScRsp")]
	CmdRogueArcadeStartScRsp = 7668,
	[OriginalName("CmdRogueArcadeLeaveCsReq")]
	CmdRogueArcadeLeaveCsReq = 7657
}
