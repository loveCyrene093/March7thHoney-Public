using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EvolveBuildStartStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EvolveBuildStartStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBFdm9sdmVCdWlsZFN0YXJ0U3RhZ2VDc1JlcS5wcm90byIuChpFdm9sdmVC" + "dWlsZFN0YXJ0U3RhZ2VDc1JlcRIQCghsZXZlbF9pZBgJIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EvolveBuildStartStageCsReq), EvolveBuildStartStageCsReq.Parser, new string[1] { "LevelId" }, null, null, null, null)
		}));
	}
}
