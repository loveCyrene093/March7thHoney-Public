using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FOCHGPGGNCLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FOCHGPGGNCLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGT0NIR1BHR05DTC5wcm90byI0CgtGT0NIR1BHR05DTBITCgtEUENGQkRD" + "RUtKTBgBIAEoDRIQCghsZXZlbF9pZBgMIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FOCHGPGGNCL), FOCHGPGGNCL.Parser, new string[2] { "DPCFBDCEKJL", "LevelId" }, null, null, null, null)
		}));
	}
}
