using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KINHLMIMDIGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KINHLMIMDIGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSU5ITE1JTURJRy5wcm90byJzCgtLSU5ITE1JTURJRxITCgtLSENQQ0tJ" + "Qk5LQhgIIAEoBRITCgtNR05HUEdQUElBQRgJIAEoDRIUCgx0b3RhbF9kYW1h" + "Z2UYDCABKAUSEwoLUEhMRUlCQkJERE4YDSABKAUSDwoHaXRlbV9pZBgPIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KINHLMIMDIG), KINHLMIMDIG.Parser, new string[5] { "KHCPCKIBNKB", "MGNGPGPPIAA", "TotalDamage", "PHLEIBBBDDN", "ItemId" }, null, null, null, null)
		}));
	}
}
