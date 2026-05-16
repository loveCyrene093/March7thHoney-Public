using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HeartDialEmotionTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HeartDialEmotionTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpIZWFydERpYWxFbW90aW9uVHlwZS5wcm90byqgAQoUSGVhcnREaWFsRW1v";
		buffer[1] = "dGlvblR5cGUSIQodSEVBUlRfRElBTF9FTU9USU9OX1RZUEVfUEVBQ0UQABIh";
		buffer[2] = "Ch1IRUFSVF9ESUFMX0VNT1RJT05fVFlQRV9BTkdFUhABEiEKHUhFQVJUX0RJ";
		buffer[3] = "QUxfRU1PVElPTl9UWVBFX0hBUFBZEAISHwobSEVBUlRfRElBTF9FTU9USU9O";
		buffer[4] = "X1RZUEVfU0FEEANCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(HeartDialEmotionType) }, null, null));
	}
}
