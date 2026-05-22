using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EBABBABOINFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EBABBABOINFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQkFCQkFCT0lORi5wcm90bypkCgtFQkFCQkFCT0lORhIbChdFQkFCQkFC" + "T0lORl9QQ1BESEVMUEtFTRAAEhsKF0VCQUJCQUJPSU5GX0NEUExQSUJES05O" + "EAESGwoXRUJBQkJBQk9JTkZfSkFJQUZQSk9ERkUQAkIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(EBABBABOINF) }, null, null));
	}
}
