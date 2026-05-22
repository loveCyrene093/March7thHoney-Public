using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdShopType
{
	[OriginalName("FMOJCFMPCNA_PCPDHELPKEM")]
	FmojcfmpcnaPcpdhelpkem = 0,
	[OriginalName("CmdEFLGLOKNBKP")]
	CmdEflgloknbkp = 1518,
	[OriginalName("CmdCityShopInfoScNotify")]
	CmdCityShopInfoScNotify = 1509,
	[OriginalName("CmdBuyGoodsCsReq")]
	CmdBuyGoodsCsReq = 1594,
	[OriginalName("CmdTakeCityShopRewardCsReq")]
	CmdTakeCityShopRewardCsReq = 1514,
	[OriginalName("CmdBuyGoodsScRsp")]
	CmdBuyGoodsScRsp = 1595,
	[OriginalName("CmdGetShopListScRsp")]
	CmdGetShopListScRsp = 1510,
	[OriginalName("CmdGetShopListCsReq")]
	CmdGetShopListCsReq = 1591
}
