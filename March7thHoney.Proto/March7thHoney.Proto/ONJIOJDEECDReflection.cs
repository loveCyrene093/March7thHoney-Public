using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ONJIOJDEECDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ONJIOJDEECDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTkpJT0pERUVDRC5wcm90byJJCgtPTkpJT0pERUVDRBINCgVsZXZlbBgJ" + "IAEoDRIWCg5xdWV1ZV9wb3NpdGlvbhgLIAEoDRITCgtKT0RHREZFRUhPUBgN" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ONJIOJDEECD), ONJIOJDEECD.Parser, new string[3] { "Level", "QueuePosition", "JODGDFEEHOP" }, null, null, null, null)
		}));
	}
}
