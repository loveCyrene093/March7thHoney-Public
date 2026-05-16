using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdMarkChestType
{
	[OriginalName("EECKHHFLCDF_PCPDHELPKEM")]
	EeckhhflcdfPcpdhelpkem = 0,
	[OriginalName("CmdGetMarkChestScRsp")]
	CmdGetMarkChestScRsp = 8200,
	[OriginalName("CmdUpdateMarkChestScRsp")]
	CmdUpdateMarkChestScRsp = 8190,
	[OriginalName("CmdGetMarkChestCsReq")]
	CmdGetMarkChestCsReq = 8181,
	[OriginalName("CmdUpdateMarkChestCsReq")]
	CmdUpdateMarkChestCsReq = 8182,
	[OriginalName("CmdMarkChestChangedScNotify")]
	CmdMarkChestChangedScNotify = 8195
}
