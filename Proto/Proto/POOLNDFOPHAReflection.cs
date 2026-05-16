using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class POOLNDFOPHAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static POOLNDFOPHAReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFQT09MTkRGT1BIQS5wcm90byqeAQoLUE9PTE5ERk9QSEESGwoXUE9PTE5E";
		buffer[1] = "Rk9QSEFfUENQREhFTFBLRU0QABIbChdQT09MTkRGT1BIQV9OT0tOTk1QTUdH";
		buffer[2] = "ThABEhsKF1BPT0xOREZPUEhBX0lBUEJNRUlPSEdHEAISGwoXUE9PTE5ERk9Q";
		buffer[3] = "SEFfREVBSEFMS09DQkQQAxIbChdQT09MTkRGT1BIQV9NRVBLSk5LQUhPQRAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(POOLNDFOPHA) }, null, null));
	}
}
