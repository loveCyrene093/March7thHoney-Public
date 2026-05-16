using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightLockTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightLockTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdHcmlkRmlnaHRMb2NrVHlwZS5wcm90byqHAQoRR3JpZEZpZ2h0TG9ja1R5";
		buffer[1] = "cGUSGwoXUEpCTUhITkxDTEJfTE5MT09IREVBRU8QABIbChdQSkJNSEhOTENM";
		buffer[2] = "Ql9FSEZIREdQT0NOSBAGEhsKF1BKQk1ISE5MQ0xCX0lBT0JMTk9FS0tIEAcS";
		buffer[3] = "GwoXUEpCTUhITkxDTEJfRUJFS1BHTEZJSU0QCEIWqgITTWFyY2g3dGhIb25l";
		buffer[4] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightLockType) }, null, null));
	}
}
