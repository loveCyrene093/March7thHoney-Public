using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JPPGLJPCFNCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JPPGLJPCFNCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKUFBHTEpQQ0ZOQy5wcm90byINCgtKUFBHTEpQQ0ZOQ0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JPPGLJPCFNC), JPPGLJPCFNC.Parser, null, null, null, null, null)
		}));
	}
}
