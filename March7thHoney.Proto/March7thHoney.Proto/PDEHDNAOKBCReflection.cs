using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PDEHDNAOKBCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PDEHDNAOKBCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQREVIRE5BT0tCQy5wcm90byIiCgtQREVIRE5BT0tCQxITCgtLTEFBRkVJ" + "TUFNSRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PDEHDNAOKBC), PDEHDNAOKBC.Parser, new string[1] { "KLAAFEIMAMI" }, null, null, null, null)
		}));
	}
}
