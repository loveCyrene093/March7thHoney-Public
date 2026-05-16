using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildReRandomStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildReRandomStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNFdm9sdmVCdWlsZFJlUmFuZG9tU3RhZ2VDc1JlcS5wcm90byIxCh1Fdm9s" + "dmVCdWlsZFJlUmFuZG9tU3RhZ2VDc1JlcRIQCghsZXZlbF9pZBgLIAEoDUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildReRandomStageCsReq), EvolveBuildReRandomStageCsReq.Parser, new string[1] { "LevelId" }, null, null, null, null)
		}));
	}
}
