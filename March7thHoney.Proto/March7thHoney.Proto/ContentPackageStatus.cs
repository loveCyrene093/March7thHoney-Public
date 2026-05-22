using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public enum ContentPackageStatus
{
	[OriginalName("ContentPackageStatus_None")]
	None,
	[OriginalName("ContentPackageStatus_Init")]
	Init,
	[OriginalName("ContentPackageStatus_Doing")]
	Doing,
	[OriginalName("ContentPackageStatus_Finished")]
	Finished,
	[OriginalName("ContentPackageStatus_Release")]
	Release
}
