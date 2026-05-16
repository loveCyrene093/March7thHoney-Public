using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JICGMEBFBJFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JICGMEBFBJFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSUNHTUVCRkJKRi5wcm90byINCgtKSUNHTUVCRkJKRkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JICGMEBFBJF), JICGMEBFBJF.Parser, null, null, null, null, null)
		}));
	}
}
