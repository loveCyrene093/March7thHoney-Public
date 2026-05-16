using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdPlayerBoardTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdPlayerBoardTypeReflection()
	{
		InlineArray13<string> buffer = default(InlineArray13<string>);
		buffer[0] = "ChhDbWRQbGF5ZXJCb2FyZFR5cGUucHJvdG8q7QMKEkNtZFBsYXllckJvYXJk";
		buffer[1] = "VHlwZRIbChdEQkNOSUFORk1MQ19QQ1BESEVMUEtFTRAAEhwKF0NtZFNldEFz";
		buffer[2] = "c2lzdEF2YXRhckNzUmVxEPEVEh0KGENtZFNldERpc3BsYXlBdmF0YXJDc1Jl";
		buffer[3] = "cRD+FRIcChdDbWRTZXRQZXJzb25hbENhcmRDU1JlcRCVFhIbChZDbWRTZXRJ";
		buffer[4] = "c09IT01ETUVKTEZLUmVxEPkVEhkKFENtZFNldFNpZ25hdHVyZVNjUnNwEJcW";
		buffer[5] = "EhwKF0RCQ05JQU5GTUxDX1BPTENPT09CQlBQEK8WEhgKE0NtZFNldEhlYWRJ";
		buffer[6] = "Y29uQ3NSZXEQzhYSHwoaQ21kR2V0UGxheWVyQm9hcmREYXRhU2NSc3AQ+hUS";
		buffer[7] = "HQoYQ21kU2V0RGlzcGxheUF2YXRhclNjUnNwEIIWEhgKE0NtZFNldEhlYWRJ";
		buffer[8] = "Y29uU2NSc3AQzxYSHQoYQ21kU2V0SXNPSE9NRE1FSkxGS1NjUnNwENIWEh8K";
		buffer[9] = "GkNtZEdldFBsYXllckJvYXJkRGF0YUNzUmVxEMsWEhkKFENtZFNldFNpZ25h";
		buffer[10] = "dHVyZUNzUmVxEIoWEhwKF0NtZFNldEFzc2lzdEF2YXRhclNjUnNwELoWEhwK";
		buffer[11] = "F0NtZFNldFBlcnNvbmFsQ2FyZFNjUnNwEPQVQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[12] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdPlayerBoardType) }, null, null));
	}
}
