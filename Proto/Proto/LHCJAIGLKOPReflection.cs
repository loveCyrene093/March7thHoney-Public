using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHCJAIGLKOPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHCJAIGLKOPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSENKQUlHTEtPUC5wcm90byINCgtMSENKQUlHTEtPUEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHCJAIGLKOP), LHCJAIGLKOP.Parser, null, null, null, null, null)
		}));
	}
}
