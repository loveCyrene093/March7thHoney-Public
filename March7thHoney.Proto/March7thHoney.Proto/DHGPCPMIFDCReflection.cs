using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DHGPCPMIFDCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DHGPCPMIFDCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESEdQQ1BNSUZEQy5wcm90byIiCgtESEdQQ1BNSUZEQxITCgtJRU5CS0lB" + "R1BCQRgDIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DHGPCPMIFDC), DHGPCPMIFDC.Parser, new string[1] { "IENBKIAGPBA" }, null, null, null, null)
		}));
	}
}
