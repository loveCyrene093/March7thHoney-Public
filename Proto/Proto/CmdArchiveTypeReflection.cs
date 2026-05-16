using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdArchiveTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdArchiveTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChRDbWRBcmNoaXZlVHlwZS5wcm90byqgAQoOQ21kQXJjaGl2ZVR5cGUSGwoX";
		buffer[1] = "Q0JMT0RFRUhGSkZfUENQREhFTFBLRU0QABIbChZDbWRHZXRBcmNoaXZlRGF0";
		buffer[2] = "YVNjUnNwEIYSEhMKDkNtZEdISUxJQ0hPRExOENsSEiIKHUNtZEdldFVwZGF0";
		buffer[3] = "ZWRBcmNoaXZlRGF0YUNzUmVxENoSEhsKFkNtZEdldEFyY2hpdmVEYXRhQ3NS";
		buffer[4] = "ZXEQ1xJCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdArchiveType) }, null, null));
	}
}
