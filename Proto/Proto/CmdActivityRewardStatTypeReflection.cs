using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdActivityRewardStatTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdActivityRewardStatTypeReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "Ch9DbWRBY3Rpdml0eVJld2FyZFN0YXRUeXBlLnByb3RvKqQCChlDbWRBY3Rp";
		buffer[1] = "dml0eVJld2FyZFN0YXRUeXBlEhsKF0dNR0dESUxFS0JOX0lIQktLSkdORE9G";
		buffer[2] = "EAASJwoiQ21kR2V0QWN0aXZpdHlSZXdhcmRDb3VudERhdGFTY1JzcBCaRxIf";
		buffer[3] = "ChpDbWRHZXRBY3Rpdml0eUhvdERhdGFDc1JlcRCfRxIfChpDbWRHZXRBY3Rp";
		buffer[4] = "dml0eUhvdERhdGFTY1JzcBCgRxInCiJDbWRHZXRBY3Rpdml0eVJld2FyZENv";
		buffer[5] = "dW50RGF0YUNzUmVxEJtHEioKJUNtZEdldEFsbEFjdGl2aXR5UmV3YXJkQ291";
		buffer[6] = "bnREYXRhU2NSc3AQnUcSKgolQ21kR2V0QWxsQWN0aXZpdHlSZXdhcmRDb3Vu";
		buffer[7] = "dERhdGFDc1JlcRCXR0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdActivityRewardStatType) }, null, null));
	}
}
