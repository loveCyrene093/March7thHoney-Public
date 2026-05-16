using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHPMLCLOAJGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHPMLCLOAJGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISFBNTENMT0FKRy5wcm90byIiCgtISFBNTENMT0FKRxITCgtERU9JQ0JC" + "R1BJQxgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHPMLCLOAJG), HHPMLCLOAJG.Parser, new string[1] { "DEOICBBGPIC" }, null, null, null, null)
		}));
	}
}
