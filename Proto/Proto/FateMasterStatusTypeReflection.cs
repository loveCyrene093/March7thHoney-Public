using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateMasterStatusTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateMasterStatusTypeReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpGYXRlTWFzdGVyU3RhdHVzVHlwZS5wcm90byqKAQoURmF0ZU1hc3RlclN0";
		buffer[1] = "YXR1c1R5cGUSGwoXS0dIT0NBUEhMREdfUENQREhFTFBLRU0QABIbChdLR0hP";
		buffer[2] = "Q0FQSExER19CTkpNUENIRklOQRABEhsKF0tHSE9DQVBITERHX0NDSkNGTUlB";
		buffer[3] = "RkNNEAISGwoXS0dIT0NBUEhMREdfUENCRk5OSkxPS0MQA0IWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(FateMasterStatusType) }, null, null));
	}
}
