using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NAFCLDABGLCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NAFCLDABGLCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQUZDTERBQkdMQy5wcm90byINCgtOQUZDTERBQkdMQ0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NAFCLDABGLC), NAFCLDABGLC.Parser, null, null, null, null, null)
		}));
	}
}
