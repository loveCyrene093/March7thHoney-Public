using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdMultiplayerType
{
	[OriginalName("MCMECKIBADN_PCPDHELPKEM")]
	McmeckibadnPcpdhelpkem = 0,
	[OriginalName("CmdMKLLLKLEEAP")]
	CmdMklllkleeap = 1063,
	[OriginalName("CmdGetMatchPlayDataCsReq")]
	CmdGetMatchPlayDataCsReq = 1026,
	[OriginalName("CmdGetFriendRankingInfoRsp")]
	CmdGetFriendRankingInfoRsp = 1037,
	[OriginalName("CmdGetFriendRankingInfoCsReq")]
	CmdGetFriendRankingInfoCsReq = 1074,
	[OriginalName("CmdFightGameStateCsReq")]
	CmdFightGameStateCsReq = 1091,
	[OriginalName("CmdFCIANJKGMCH")]
	CmdFcianjkgmch = 1098,
	[OriginalName("CmdPlayerGetFightGateCsReq")]
	CmdPlayerGetFightGateCsReq = 1094,
	[OriginalName("CmdFightGiveUpCsReq")]
	CmdFightGiveUpCsReq = 1014,
	[OriginalName("CmdGetMatchPlayDataRsp")]
	CmdGetMatchPlayDataRsp = 1039,
	[OriginalName("CmdLOKAJGFMKAK")]
	CmdLokajgfmkak = 1095,
	[OriginalName("CmdFightGameStateScRsp")]
	CmdFightGameStateScRsp = 1010,
	[OriginalName("CmdSelfRankChangeNtf")]
	CmdSelfRankChangeNtf = 1004,
	[OriginalName("CmdMatchPlayDataChangeNtf")]
	CmdMatchPlayDataChangeNtf = 1001,
	[OriginalName("CmdFightGameStartScNotify")]
	CmdFightGameStartScNotify = 1009,
	[OriginalName("CmdDGEEILCMHHE")]
	CmdDgeeilcmhhe = 1018
}
