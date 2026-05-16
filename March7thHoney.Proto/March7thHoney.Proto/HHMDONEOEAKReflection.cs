using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHMDONEOEAKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHMDONEOEAKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISE1ET05FT0VBSy5wcm90byIiCgtISE1ET05FT0VBSxITCgtNQ09BTVBL" + "S0xKTBgLIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHMDONEOEAK), HHMDONEOEAK.Parser, new string[1] { "MCOAMPKKLJL" }, null, null, null, null)
		}));
	}
}
