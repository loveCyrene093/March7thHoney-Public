using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GHJIFOHJOEMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GHJIFOHJOEMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHSEpJRk9ISk9FTS5wcm90byqBAQoLR0hKSUZPSEpPRU0SGwoXR0hKSUZP";
		buffer[1] = "SEpPRU1fS0lQQ0VGTUdQRUUQABIbChdHSEpJRk9ISk9FTV9GSkhNRExPTENH";
		buffer[2] = "SBABEhsKF0dISklGT0hKT0VNX01PRU1MQ0dJSE5GEAISGwoXR0hKSUZPSEpP";
		buffer[3] = "RU1fR05JR0FCSklDTkoQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GHJIFOHJOEM) }, null, null));
	}
}
