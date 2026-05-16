using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPamMissionTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPamMissionTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChdDbWRQYW1NaXNzaW9uVHlwZS5wcm90byqSAQoRQ21kUGFtTWlzc2lvblR5";
		buffer[1] = "cGUSGwoXUEJNRElEUEFOT0lfUENQREhFTFBLRU0QABITCg5DbWRPTExOS1BI";
		buffer[2] = "TUVQSBCqHxIkCh9DbWRTeW5jQWNjZXB0ZWRQYW1NaXNzaW9uTm90aWZ5EP4f";
		buffer[3] = "EiUKIENtZEFjY2VwdGVkUGFtTWlzc2lvbkV4cGlyZUNzUmVxEPsfQhaqAhNN";
		buffer[4] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPamMissionType) }, null, null));
	}
}
