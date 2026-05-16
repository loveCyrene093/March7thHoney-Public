using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdMarkChestTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdMarkChestTypeReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChZDbWRNYXJrQ2hlc3RUeXBlLnByb3RvKsMBChBDbWRNYXJrQ2hlc3RUeXBl";
		buffer[1] = "EhsKF0VFQ0tISEZMQ0RGX1BDUERIRUxQS0VNEAASGQoUQ21kR2V0TWFya0No";
		buffer[2] = "ZXN0U2NSc3AQiEASHAoXQ21kVXBkYXRlTWFya0NoZXN0U2NSc3AQ/j8SGQoU";
		buffer[3] = "Q21kR2V0TWFya0NoZXN0Q3NSZXEQ9T8SHAoXQ21kVXBkYXRlTWFya0NoZXN0";
		buffer[4] = "Q3NSZXEQ9j8SIAobQ21kTWFya0NoZXN0Q2hhbmdlZFNjTm90aWZ5EINAQhaq";
		buffer[5] = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdMarkChestType) }, null, null));
	}
}
