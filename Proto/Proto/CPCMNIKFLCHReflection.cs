using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CPCMNIKFLCHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CPCMNIKFLCHReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFDUENNTklLRkxDSC5wcm90byqeAQoLQ1BDTU5JS0ZMQ0gSGwoXQ1BDTU5J";
		buffer[1] = "S0ZMQ0hfS0JKQUlLSkVGQkIQABIbChdDUENNTklLRkxDSF9IUExMQ0REQkZE";
		buffer[2] = "QxABEhsKF0NQQ01OSUtGTENIX0NCSUtGUEhJTEtCEAISGwoXQ1BDTU5JS0ZM";
		buffer[3] = "Q0hfRkJPTEpGSUJCR00QAxIbChdDUENNTklLRkxDSF9GSUVFSk5QT0hERRAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CPCMNIKFLCH) }, null, null));
	}
}
