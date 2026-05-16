using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightDropTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightDropTypeReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChdHcmlkRmlnaHREcm9wVHlwZS5wcm90byr7AQoRR3JpZEZpZ2h0RHJvcFR5";
		buffer[1] = "cGUSGwoXSElPTENOUE9QT05fUENQREhFTFBLRU0QABIbChdISU9MQ05QT1BP";
		buffer[2] = "Tl9ISE5CR05GQkRITxABEhsKF0hJT0xDTlBPUE9OX0hPTE9KSEdHSU9HEAIS";
		buffer[3] = "GwoXSElPTENOUE9QT05fTk9LTk5NUE1HR04QAxIbChdISU9MQ05QT1BPTl9O";
		buffer[4] = "T0ZQSURQSUtMShAEEhsKF0hJT0xDTlBPUE9OX0JJS0hPRUdGRUZEEAUSGwoX";
		buffer[5] = "SElPTENOUE9QT05fTUtQUENEUENISUUQBhIbChdISU9MQ05QT1BPTl9CSEpP";
		buffer[6] = "S0xMSkxQTBAHQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(GridFightDropType) }, null, null));
	}
}
