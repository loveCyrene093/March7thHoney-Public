using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EENMIGNAPKHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EENMIGNAPKHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRU5NSUdOQVBLSC5wcm90byI3CgtFRU5NSUdOQVBLSBITCgtDREtFREZQ" + "RUZJShgBIAEoDRITCgtBQ01HQk5ORUFDShgDIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EENMIGNAPKH), EENMIGNAPKH.Parser, new string[2] { "CDKEDFPEFIJ", "ACMGBNNEACJ" }, null, null, null, null)
		}));
	}
}
