using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JDKJPFGJOBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JDKJPFGJOBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKREtKUEZHSk9CSS5wcm90bypkCgtKREtKUEZHSk9CSRIbChdKREtKUEZH" + "Sk9CSV9QQ1BESEVMUEtFTRAAEhsKF0pES0pQRkdKT0JJX01CSkhHTkhPR0xH" + "EAESGwoXSkRLSlBGR0pPQklfTEJITEhHRUVOS0sQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JDKJPFGJOBI) }, null, null));
	}
}
