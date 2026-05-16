using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NFKEJJIHOCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NFKEJJIHOCJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFORktFSkpJSE9DSi5wcm90byqeAQoLTkZLRUpKSUhPQ0oSGwoXTkZLRUpK";
		buffer[1] = "SUhPQ0pfUENQREhFTFBLRU0QABIbChdORktFSkpJSE9DSl9PUENHTkpNR0pE";
		buffer[2] = "RRABEhsKF05GS0VKSklIT0NKX01IT0dGQkpMREVEEAISGwoXTkZLRUpKSUhP";
		buffer[3] = "Q0pfRkVQR0hGRkxHSUoQAxIbChdORktFSkpJSE9DSl9CRURQS1BGTk1OQhAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NFKEJJIHOCJ) }, null, null));
	}
}
