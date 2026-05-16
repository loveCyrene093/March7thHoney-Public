using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BGKDOOJAHAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BGKDOOJAHAMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCR0tET09KQUhBTS5wcm90byIiCgtCR0tET09KQUhBTRITCgtCTkdKSEpL" + "SkFNTRgHIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BGKDOOJAHAM), BGKDOOJAHAM.Parser, new string[1] { "BNGJHJKJAMM" }, null, null, null, null)
		}));
	}
}
