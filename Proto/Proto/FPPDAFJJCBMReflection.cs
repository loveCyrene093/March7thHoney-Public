using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FPPDAFJJCBMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FPPDAFJJCBMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGUFBEQUZKSkNCTS5wcm90byqeAQoLRlBQREFGSkpDQk0SGwoXRlBQREFG";
		buffer[1] = "SkpDQk1fUENQREhFTFBLRU0QABIbChdGUFBEQUZKSkNCTV9NQkhBS0NKTE9B";
		buffer[2] = "ShABEhsKF0ZQUERBRkpKQ0JNX0RDTk1ETkFQQkRKEAISGwoXRlBQREFGSkpD";
		buffer[3] = "Qk1fTkNFQUpESE9QSUwQAxIbChdGUFBEQUZKSkNCTV9OT0lFR0ZKUEdMSRAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FPPDAFJJCBM) }, null, null));
	}
}
