using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JKFDCJBBABPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JKFDCJBBABPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKS0ZEQ0pCQkFCUC5wcm90byINCgtKS0ZEQ0pCQkFCUEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JKFDCJBBABP), JKFDCJBBABP.Parser, null, null, null, null, null)
		}));
	}
}
