using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FBKBOKHCLLFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FBKBOKHCLLFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFGQktCT0tIQ0xMRi5wcm90byqBAQoLRkJLQk9LSENMTEYSGwoXRkJLQk9L";
		buffer[1] = "SENMTEZfTk1KQktPTUlQTlAQABIbChdGQktCT0tIQ0xMRl9EREZGTkJQSERN";
		buffer[2] = "SRABEhsKF0ZCS0JPS0hDTExGX01IUEZFR0RLSUtDEAISGwoXRkJLQk9LSENM";
		buffer[3] = "TEZfQURFQU1OQUhCUEUQA0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		buffer[4] = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FBKBOKHCLLF) }, null, null));
	}
}
