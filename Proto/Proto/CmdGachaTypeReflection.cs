using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdGachaTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdGachaTypeReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "ChJDbWRHYWNoYVR5cGUucHJvdG8q6gIKDENtZEdhY2hhVHlwZRIbChdMQ0lP";
		buffer[1] = "UEFGSU9JSl9QQ1BESEVMUEtFTRAAEhwKF0NtZEV4Y2hhbmdlR2FjaGFDZWls";
		buffer[2] = "aW5nEM4PEhQKD0NtZERvR2FjaGFTY1JzcBDLDxIcChdDbWRHZXRHYWNoYUNl";
		buffer[3] = "aWxpbmdTY1JzcBD+DhIZChRDbWRHZXRHYWNoYUluZm9Dc1JlcRDHDxIcChdM";
		buffer[4] = "Q0lPUEFGSU9JSl9BSkRLR0pNTkdLQRCTDxIfChpDbWRTZXRHYWNoYURlY2lk";
		buffer[5] = "ZUl0ZW1Dc1JlcRCrDxIUCg9DbWREb0dhY2hhQ3NSZXEQyg8SIQocQ21kRXhj";
		buffer[6] = "aGFuZ2VHYWNoYUNlaWxpbmdDc1JlcRD1DhIfChpDbWRTZXRHYWNoYURlY2lk";
		buffer[7] = "ZUl0ZW1TY1JzcBCGDxIcChdDbWRHZXRHYWNoYUNlaWxpbmdDc1JlcRD6DhIZ";
		buffer[8] = "ChRDbWRHZXRHYWNoYUluZm9TY1JzcBD2DkIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[9] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdGachaType) }, null, null));
	}
}
