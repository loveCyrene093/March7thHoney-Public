using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChessRogueDiceStatusReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChessRogueDiceStatusReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpDaGVzc1JvZ3VlRGljZVN0YXR1cy5wcm90byqKAQoUQ2hlc3NSb2d1ZURp";
		buffer[1] = "Y2VTdGF0dXMSGwoXSFBIQkVHSkRJSURfRU9CQkJCRUhOTkgQABIbChdIUEhC";
		buffer[2] = "RUdKRElJRF9OQkRCQUdDT0tQThABEhsKF0hQSEJFR0pESUlEX01FTkpQRUdJ";
		buffer[3] = "Qk5DEAISGwoXSFBIQkVHSkRJSURfSkVKS09PR0dFSEEQA0IWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChessRogueDiceStatus) }, null, null));
	}
}
