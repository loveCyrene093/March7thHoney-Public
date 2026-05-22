using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ABINPBKHLPCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ABINPBKHLPCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQklOUEJLSExQQy5wcm90byI3CgtBQklOUEJLSExQQxITCgtLQkJQTktH" + "R0NQThgHIAMoDRITCgtPUEhQTUtGR0xCQRgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ABINPBKHLPC), ABINPBKHLPC.Parser, new string[2] { "KBBPNKGGCPN", "OPHPMKFGLBA" }, null, null, null, null)
		}));
	}
}
