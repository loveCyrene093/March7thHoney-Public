using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LACLGMFHPFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LACLGMFHPFGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQUNMR01GSFBGRy5wcm90byI3CgtMQUNMR01GSFBGRxITCgtMTVBJQkJO" + "RktNQxgMIAEoCBITCgtHT0RETkRQTUJJSxgNIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LACLGMFHPFG), LACLGMFHPFG.Parser, new string[2] { "LMPIBBNFKMC", "GODDNDPMBIK" }, null, null, null, null)
		}));
	}
}
