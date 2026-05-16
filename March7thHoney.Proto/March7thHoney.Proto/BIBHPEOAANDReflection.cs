using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BIBHPEOAANDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BIBHPEOAANDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSUJIUEVPQUFORC5wcm90byIiCgtCSUJIUEVPQUFORBITCgtPRE1HSURN" + "SkhPTBgHIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BIBHPEOAAND), BIBHPEOAAND.Parser, new string[1] { "ODMGIDMJHOL" }, null, null, null, null)
		}));
	}
}
