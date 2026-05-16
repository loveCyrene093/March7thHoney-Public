using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MPKJECNGFPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MPKJECNGFPFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFNUEtKRUNOR0ZQRi5wcm90byqeAQoLTVBLSkVDTkdGUEYSGwoXTVBLSkVD";
		buffer[1] = "TkdGUEZfR0tKR01EQU9LR04QABIbChdNUEtKRUNOR0ZQRl9NREVFQ0hPTU1J";
		buffer[2] = "ShABEhsKF01QS0pFQ05HRlBGX0lQT0ZGRU5FRk5IEAISGwoXTVBLSkVDTkdG";
		buffer[3] = "UEZfQ0tKQUpPSEFOTUMQAxIbChdNUEtKRUNOR0ZQRl9ESklKSUtLSUpNSBAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(MPKJECNGFPF) }, null, null));
	}
}
