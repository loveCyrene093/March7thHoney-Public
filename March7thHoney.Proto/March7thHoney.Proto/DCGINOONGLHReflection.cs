using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DCGINOONGLHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DCGINOONGLHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEQ0dJTk9PTkdMSC5wcm90byINCgtEQ0dJTk9PTkdMSEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DCGINOONGLH), DCGINOONGLH.Parser, null, null, null, null, null)
		}));
	}
}
