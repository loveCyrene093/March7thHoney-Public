using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AlleyEventStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AlleyEventStateReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChVBbGxleUV2ZW50U3RhdGUucHJvdG8qhQEKD0FsbGV5RXZlbnRTdGF0ZRIb";
		buffer[1] = "ChdIRUJBR0hMRUVDSF9NRkRQTEFPRUtGRRAAEhsKF0hFQkFHSExFRUNIX0dL";
		buffer[2] = "Qk9ESkZBSkNFEAESGwoXSEVCQUdITEVFQ0hfRE9JQlBGTk9KRkoQAhIbChdI";
		buffer[3] = "RUJBR0hMRUVDSF9EQUZBRERJRU5JSBADQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[4] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(AlleyEventState) }, null, null));
	}
}
