using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KGFMBNIIPPAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KGFMBNIIPPAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFLR0ZNQk5JSVBQQS5wcm90byqBAQoLS0dGTUJOSUlQUEESGwoXS0dGTUJO";
		buffer[1] = "SUlQUEFfSEhIQUtITU9IQkIQABIbChdLR0ZNQk5JSVBQQV9JRU5DTkdPQU1C";
		buffer[2] = "TBABEhsKF0tHRk1CTklJUFBBX0RFS0RFTkZNQ01QEAISGwoXS0dGTUJOSUlQ";
		buffer[3] = "UEFfS1BQSk1KRUhBRkIQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(KGFMBNIIPPA) }, null, null));
	}
}
