using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GGCFFJGCPKDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GGCFFJGCPKDReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHR0NGRkpHQ1BLRC5wcm90byqeAQoLR0dDRkZKR0NQS0QSGwoXR0dDRkZK";
		buffer[1] = "R0NQS0RfUENQREhFTFBLRU0QABIbChdHR0NGRkpHQ1BLRF9ESERGTkNCQU5B";
		buffer[2] = "RxABEhsKF0dHQ0ZGSkdDUEtEX0VKS0lDR0tQS05EEAISGwoXR0dDRkZKR0NQ";
		buffer[3] = "S0RfSUVIS0dJTkFIS0IQAxIbChdHR0NGRkpHQ1BLRF9HQkFKR0VOT0dNSRAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GGCFFJGCPKD) }, null, null));
	}
}
