using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LimaoNewsOfficeSurveyStateReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LimaoNewsOfficeSurveyStateReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiBMaW1hb05ld3NPZmZpY2VTdXJ2ZXlTdGF0ZS5wcm90byqtAQoaTGltYW9O";
		buffer[1] = "ZXdzT2ZmaWNlU3VydmV5U3RhdGUSGwoXS01QSUhIQkxPQUJfUENQREhFTFBL";
		buffer[2] = "RU0QABIbChdLTVBJSEhCTE9BQl9JSEFPS0xHT0tDSBABEhsKF0tNUElISEJM";
		buffer[3] = "T0FCX09QTkFERktCR05OEAISGwoXS01QSUhIQkxPQUJfRkZMQ0hMUE9GTk0Q";
		buffer[4] = "AxIbChdLTVBJSEhCTE9BQl9QT09MQUdIR0NNRxAEQhaqAhNNYXJjaDd0aEhv";
		buffer[5] = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(LimaoNewsOfficeSurveyState) }, null, null));
	}
}
