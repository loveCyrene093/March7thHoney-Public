using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum CmdContentPackageType
{
	[OriginalName("CGDHKGPIDLM_PCPDHELPKEM")]
	CgdhkgpidlmPcpdhelpkem = 0,
	[OriginalName("CmdContentPackageSyncDataScNotify")]
	CmdContentPackageSyncDataScNotify = 7530,
	[OriginalName("CmdContentPackageGetDataCsReq")]
	CmdContentPackageGetDataCsReq = 7513,
	[OriginalName("CmdContentPackageGetDataScRsp")]
	CmdContentPackageGetDataScRsp = 7507,
	[OriginalName("CmdContentPackageTransferScNotify")]
	CmdContentPackageTransferScNotify = 7538
}
