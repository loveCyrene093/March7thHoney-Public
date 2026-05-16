using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NKGNOOMGBIMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NKGNOOMGBIMReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFOS0dOT09NR0JJTS5wcm90byqeAQoLTktHTk9PTUdCSU0SGwoXTktHTk9P";
		buffer[1] = "TUdCSU1fRUNIUE9OSEFNQ04QABIbChdOS0dOT09NR0JJTV9FQ0hFS1BNTEdE";
		buffer[2] = "TRABEhsKF05LR05PT01HQklNX1BKS0tCRkZDRUhGEAISGwoXTktHTk9PTUdC";
		buffer[3] = "SU1fUERFQUtIQUtLQ0QQAxIbChdOS0dOT09NR0JJTV9EQUtMQkdLRUhBTBAE";
		buffer[4] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(NKGNOOMGBIM) }, null, null));
	}
}
