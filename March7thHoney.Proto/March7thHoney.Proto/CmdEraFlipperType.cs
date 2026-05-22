using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdEraFlipperType
{
	[OriginalName("FINOGKEDFKG_PCPDHELPKEM")]
	FinogkedfkgPcpdhelpkem = 0,
	[OriginalName("CmdResetEraFlipperDataCsReq")]
	CmdResetEraFlipperDataCsReq = 6553,
	[OriginalName("CmdChangeEraFlipperDataCsReq")]
	CmdChangeEraFlipperDataCsReq = 6552,
	[OriginalName("CmdChangeEraFlipperDataScRsp")]
	CmdChangeEraFlipperDataScRsp = 6564,
	[OriginalName("CmdPNKDIILAIPB")]
	CmdPnkdiilaipb = 6554,
	[OriginalName("CmdResetEraFlipperDataScRsp")]
	CmdResetEraFlipperDataScRsp = 6558,
	[OriginalName("CmdGetEraFlipperDataCsReq")]
	CmdGetEraFlipperDataCsReq = 6551,
	[OriginalName("CmdEnterEraFlipperRegionScRsp")]
	CmdEnterEraFlipperRegionScRsp = 6559,
	[OriginalName("CmdEnterEraFlipperDataCsReq")]
	CmdEnterEraFlipperDataCsReq = 6560,
	[OriginalName("CmdEraFlipperDataChangeScNotify")]
	CmdEraFlipperDataChangeScNotify = 6569
}
