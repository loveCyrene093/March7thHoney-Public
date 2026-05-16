using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LPFDDGKBAAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LPFDDGKBAAMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMUEZEREdLQkFBTS5wcm90byIiCgtMUEZEREdLQkFBTRITCgtMRUNGS0dM" + "RUtDShgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LPFDDGKBAAM), LPFDDGKBAAM.Parser, new string[1] { "LECFKGLEKCJ" }, null, null, null, null)
		}));
	}
}
