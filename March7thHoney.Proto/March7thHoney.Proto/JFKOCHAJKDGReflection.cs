using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JFKOCHAJKDGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JFKOCHAJKDGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKRktPQ0hBSktERy5wcm90byINCgtKRktPQ0hBSktER0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JFKOCHAJKDG), JFKOCHAJKDG.Parser, null, null, null, null, null)
		}));
	}
}
