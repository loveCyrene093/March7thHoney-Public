using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdOfferingTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdOfferingTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChVDbWRPZmZlcmluZ1R5cGUucHJvdG8qjAIKD0NtZE9mZmVyaW5nVHlwZRIb";
		buffer[1] = "ChdFQkhHR01CQ0JJQV9QQ1BESEVMUEtFTRAAEh8KGkNtZFN1Ym1pdE9mZmVy";
		buffer[2] = "aW5nSXRlbVNjUnNwEJI2Eh8KGkNtZFRha2VPZmZlcmluZ1Jld2FyZFNjUnNw";
		buffer[3] = "EJA2EhwKF0NtZEdldE9mZmVyaW5nSW5mb1NjUnNwEJw2EhwKF0NtZE9mZmVy";
		buffer[4] = "aW5nSW5mb1NjTm90aWZ5EJY2EhwKF0NtZEdldE9mZmVyaW5nSW5mb0NzUmVx";
		buffer[5] = "EIk2Eh8KGkNtZFRha2VPZmZlcmluZ1Jld2FyZENzUmVxEJc2Eh8KGkNtZFN1";
		buffer[6] = "Ym1pdE9mZmVyaW5nSXRlbUNzUmVxEIo2QhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[7] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdOfferingType) }, null, null));
	}
}
