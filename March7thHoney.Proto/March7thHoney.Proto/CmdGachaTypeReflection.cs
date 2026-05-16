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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "ChJDbWRHYWNoYVR5cGUucHJvdG8q6gIKDENtZEdhY2hhVHlwZRIbChdMQ0lP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "UEFGSU9JSl9QQ1BESEVMUEtFTRAAEhwKF0NtZEV4Y2hhbmdlR2FjaGFDZWls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "aW5nEM4PEhQKD0NtZERvR2FjaGFTY1JzcBDLDxIcChdDbWRHZXRHYWNoYUNl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "aWxpbmdTY1JzcBD+DhIZChRDbWRHZXRHYWNoYUluZm9Dc1JlcRDHDxIcChdM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "Q0lPUEFGSU9JSl9BSkRLR0pNTkdLQRCTDxIfChpDbWRTZXRHYWNoYURlY2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "ZUl0ZW1Dc1JlcRCrDxIUCg9DbWREb0dhY2hhQ3NSZXEQyg8SIQocQ21kRXhj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "aGFuZ2VHYWNoYUNlaWxpbmdDc1JlcRD1DhIfChpDbWRTZXRHYWNoYURlY2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "ZUl0ZW1TY1JzcBCGDxIcChdDbWRHZXRHYWNoYUNlaWxpbmdDc1JlcRD6DhIZ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "ChRDbWRHZXRHYWNoYUluZm9TY1JzcBD2DkIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdGachaType) }, null, null));
	}
}
