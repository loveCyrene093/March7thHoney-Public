using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BJKAKGBONBMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BJKAKGBONBMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSktBS0dCT05CTS5wcm90byIiCgtCSktBS0dCT05CTRITCgtGT09MTUlB" + "RE1NSBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BJKAKGBONBM), BJKAKGBONBM.Parser, new string[1] { "FOOLMIADMMH" }, null, null, null, null)
		}));
	}
}
