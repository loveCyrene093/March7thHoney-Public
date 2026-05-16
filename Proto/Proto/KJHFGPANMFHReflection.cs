using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KJHFGPANMFHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KJHFGPANMFHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSkhGR1BBTk1GSC5wcm90bxoRSEhPS0VKTEdPQk4ucHJvdG8iRQoLS0pI" + "RkdQQU5NRkgSEwoLSE1JQkpIRE1MTkIYAyABKA0SIQoLS0dLT0hOQUFDRU4Y" + "BCABKAsyDC5ISE9LRUpMR09CTkIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IG" + "cHJvdG8z"), new FileDescriptor[1] { HHOKEJLGOBNReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KJHFGPANMFH), KJHFGPANMFH.Parser, new string[2] { "HMIBJHDMLNB", "KGKOHNAACEN" }, null, null, null, null)
		}));
	}
}
