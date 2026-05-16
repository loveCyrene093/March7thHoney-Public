using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdEraFlipperTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdEraFlipperTypeReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChdDbWRFcmFGbGlwcGVyVHlwZS5wcm90byrbAgoRQ21kRXJhRmxpcHBlclR5";
		buffer[1] = "cGUSGwoXRklOT0dLRURGS0dfUENQREhFTFBLRU0QABIgChtDbWRSZXNldEVy";
		buffer[2] = "YUZsaXBwZXJEYXRhQ3NSZXEQmTMSIQocQ21kQ2hhbmdlRXJhRmxpcHBlckRh";
		buffer[3] = "dGFDc1JlcRCYMxIhChxDbWRDaGFuZ2VFcmFGbGlwcGVyRGF0YVNjUnNwEKQz";
		buffer[4] = "EhMKDkNtZFBOS0RJSUxBSVBCEJozEiAKG0NtZFJlc2V0RXJhRmxpcHBlckRh";
		buffer[5] = "dGFTY1JzcBCeMxIeChlDbWRHZXRFcmFGbGlwcGVyRGF0YUNzUmVxEJczEiIK";
		buffer[6] = "HUNtZEVudGVyRXJhRmxpcHBlclJlZ2lvblNjUnNwEJ8zEiAKG0NtZEVudGVy";
		buffer[7] = "RXJhRmxpcHBlckRhdGFDc1JlcRCgMxIkCh9DbWRFcmFGbGlwcGVyRGF0YUNo";
		buffer[8] = "YW5nZVNjTm90aWZ5EKkzQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[9] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdEraFlipperType) }, null, null));
	}
}
