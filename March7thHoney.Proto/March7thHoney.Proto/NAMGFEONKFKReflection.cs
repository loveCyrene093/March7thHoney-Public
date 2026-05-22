using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NAMGFEONKFKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NAMGFEONKFKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQU1HRkVPTktGSy5wcm90byIiCgtOQU1HRkVPTktGSxITCgtDQ0lFSUFB" + "RExNRRgHIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NAMGFEONKFK), NAMGFEONKFK.Parser, new string[1] { "CCIEIAADLME" }, null, null, null, null)
		}));
	}
}
