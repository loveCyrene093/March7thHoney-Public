using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MLLIDMPEFODReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MLLIDMPEFODReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTExJRE1QRUZPRC5wcm90byIiCgtNTExJRE1QRUZPRBITCgtHT0NHRk1B" + "TEVPUBgJIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MLLIDMPEFOD), MLLIDMPEFOD.Parser, new string[1] { "GOCGFMALEOP" }, null, null, null, null)
		}));
	}
}
