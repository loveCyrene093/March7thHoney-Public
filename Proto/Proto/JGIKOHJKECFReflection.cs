using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JGIKOHJKECFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JGIKOHJKECFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFKR0lLT0hKS0VDRi5wcm90byqeAQoLSkdJS09ISktFQ0YSGwoXSkdJS09I";
		buffer[1] = "SktFQ0ZfUENQREhFTFBLRU0QABIbChdKR0lLT0hKS0VDRl9PRE9LSk9NRUNI";
		buffer[2] = "SRABEhsKF0pHSUtPSEpLRUNGX0pLQ09BSk9EUE1MEAISGwoXSkdJS09ISktF";
		buffer[3] = "Q0ZfR1BQUExBQ0pLSkoQAxIbChdKR0lLT0hKS0VDRl9JR0hBSEVFSExERxAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(JGIKOHJKECF) }, null, null));
	}
}
