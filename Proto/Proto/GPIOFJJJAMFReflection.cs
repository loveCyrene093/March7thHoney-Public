using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GPIOFJJJAMFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GPIOFJJJAMFReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFHUElPRkpKSkFNRi5wcm90byqeAQoLR1BJT0ZKSkpBTUYSGwoXR1BJT0ZK";
		buffer[1] = "SkpBTUZfREJJSE1OR0xPR0wQABIbChdHUElPRkpKSkFNRl9HSEZJTkRJREJQ";
		buffer[2] = "SRABEhsKF0dQSU9GSkpKQU1GX01IRk5FTk1QTUJLEAISGwoXR1BJT0ZKSkpB";
		buffer[3] = "TUZfUEdHQUZQTUdFTEMQAxIbChdHUElPRkpKSkFNRl9NSE1PTEtPSU5OSxAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GPIOFJJJAMF) }, null, null));
	}
}
