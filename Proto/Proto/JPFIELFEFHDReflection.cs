using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JPFIELFEFHDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JPFIELFEFHDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKUEZJRUxGRUZIRC5wcm90byJhCgtKUEZJRUxGRUZIRBITCgtLQkJQTktH" + "R0NQThgBIAMoDRITCgtMUEpJSkhHUEdITRgGIAEoDRITCgtPUEhQTUtGR0xC" + "QRgNIAEoDRITCgtOSkFDTU1OUENCShgPIAMoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JPFIELFEFHD), JPFIELFEFHD.Parser, new string[4] { "KBBPNKGGCPN", "LPJIJHGPGHM", "OPHPMKFGLBA", "NJACMMNPCBJ" }, null, null, null, null)
		}));
	}
}
