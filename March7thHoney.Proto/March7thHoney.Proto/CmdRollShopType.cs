using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdRollShopType
{
	[OriginalName("MNCIAAAFPKK_PCPDHELPKEM")]
	MnciaaafpkkPcpdhelpkem = 0,
	[OriginalName("CmdGetRollShopInfoCsReq")]
	CmdGetRollShopInfoCsReq = 6901,
	[OriginalName("CmdDoGachaInRollShopCsReq")]
	CmdDoGachaInRollShopCsReq = 6902,
	[OriginalName("CmdGetRollShopInfoScRsp")]
	CmdGetRollShopInfoScRsp = 6920,
	[OriginalName("CmdDoGachaInRollShopScRsp")]
	CmdDoGachaInRollShopScRsp = 6910,
	[OriginalName("CmdTakeRollShopRewardScRsp")]
	CmdTakeRollShopRewardScRsp = 6908,
	[OriginalName("CmdTakeRollShopRewardCsReq")]
	CmdTakeRollShopRewardCsReq = 6915
}
