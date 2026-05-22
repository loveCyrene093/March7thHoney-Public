using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FMMIGGLFAFBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FMMIGGLFAFBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTU1JR0dMRkFGQi5wcm90byINCgtGTU1JR0dMRkFGQkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FMMIGGLFAFB), FMMIGGLFAFB.Parser, null, null, null, null, null)
		}));
	}
}
