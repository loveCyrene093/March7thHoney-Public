using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BpRewardTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BpRewardTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChJCcFJld2FyZFR5cGUucHJvdG8qnwEKDEJwUmV3YXJkVHlwZRIbChdGQUFK";
		buffer[1] = "S0NBQ0dDRF9PRUpDRUNCQ0hMQxAAEhsKF0ZBQUpLQ0FDR0NEX0ZPT0hEQUJI";
		buffer[2] = "REtNEAESGwoXRkFBSktDQUNHQ0RfR0lJTUJFT1BERkIQAhIbChdGQUFKS0NB";
		buffer[3] = "Q0dDRF9QQk9NR09LQU5KRBADEhsKF0ZBQUpLQ0FDR0NEX0pGTUJORU1JREZL";
		buffer[4] = "EARCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(BpRewardType) }, null, null));
	}
}
