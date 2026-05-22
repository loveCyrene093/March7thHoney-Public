using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MMIBACFNELBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MMIBACFNELBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTUlCQUNGTkVMQi5wcm90byINCgtNTUlCQUNGTkVMQkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MMIBACFNELB), MMIBACFNELB.Parser, null, null, null, null, null)
		}));
	}
}
