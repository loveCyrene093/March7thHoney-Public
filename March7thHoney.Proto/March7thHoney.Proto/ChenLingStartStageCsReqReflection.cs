using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingStartStageCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingStartStageCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1DaGVuTGluZ1N0YXJ0U3RhZ2VDc1JlcS5wcm90byJAChdDaGVuTGluZ1N0" + "YXJ0U3RhZ2VDc1JlcRIQCghzdGFnZV9pZBgCIAEoDRITCgtNSElGRkFNTUFH" + "SRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingStartStageCsReq), ChenLingStartStageCsReq.Parser, new string[2] { "StageId", "MHIFFAMMAGI" }, null, null, null, null)
		}));
	}
}
