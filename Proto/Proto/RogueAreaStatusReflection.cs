using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueAreaStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueAreaStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChVSb2d1ZUFyZWFTdGF0dXMucHJvdG8qhQEKD1JvZ3VlQXJlYVN0YXR1cxIb";
		buffer[1] = "ChdGRFBPQVBMQkZLQ19ES0xQQUFGRkxFRRAAEhsKF0ZEUE9BUExCRktDX05H";
		buffer[2] = "TU1JQ09HREZQEAESGwoXRkRQT0FQTEJGS0NfT05NSUJCRU1HSk8QAhIbChdG";
		buffer[3] = "RFBPQVBMQkZLQ19DTFBITUFKSklMQRADQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(RogueAreaStatus) }, null, null));
	}
}
