using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CmdHipplenTypeReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CmdHipplenTypeReflection()
	{
		InlineArray16<string> buffer = default(InlineArray16<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 0) = "ChRDbWRIaXBwbGVuVHlwZS5wcm90byr5BAoOQ21kSGlwcGxlblR5cGUSGwoX";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 1) = "T0JKTE5PQ0ZCSU9fUENQREhFTFBLRU0QABIdChhDbWRTZXRIaXBwbGVuT3V0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 2) = "Zml0Q3NSZXEQukYSJAofQ21kVGFrZUhpcHBsZW5FbmRpbmdSZXdhcmRDc1Jl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 3) = "cRC4RhIeChlDbWRHZXRIaXBwbGVuSW5oZXJpdFNjUnNwEMNGEh4KGUNtZEdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 4) = "dEhpcHBsZW5Jbmhlcml0Q3NSZXEQxkYSIgodQ21kSGlwcGxlblRyYWl0VW5s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 5) = "b2NrU2NOb3RpZnkQ2kYSHQoYQ21kU2V0SGlwcGxlbkFnZW5kYUNzUmVxEMtG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 6) = "Eh4KGUNtZFNldHRsZUhpcHBsZW5Xb3JrQ3NSZXEQrUYSHQoYQ21kT3Blbkhp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 7) = "cHBsZW5DeWNsZVNjUnNwENRGEiMKHkNtZEhpcHBsZW5BZ2VuZGFSZXN1bHRT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 8) = "Y05vdGlmeRDXRhIbChZDbWRHZXRIaXBwbGVuRGF0YUNzUmVxELVGEh4KGUNt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 9) = "ZFNldHRsZUhpcHBsZW5Xb3JrU2NSc3AQqUYSGwoWQ21kR2V0SGlwcGxlbkRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 10) = "dGFTY1JzcBCvRhIiCh1DbWRIaXBwbGVuQ3ljbGVSZXN1bHRTY05vdGlmeRC7";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 11) = "RhIdChhDbWRTZXRIaXBwbGVuT3V0Zml0U2NSc3AQ1UYSHQoYQ21kU2V0SGlw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 12) = "cGxlbkFnZW5kYVNjUnNwEM5GEiQKH0NtZFRha2VIaXBwbGVuRW5kaW5nUmV3";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 13) = "YXJkU2NSc3AQx0YSHQoYQ21kSGlwcGxlbkNoYW5nZVNjTm90aWZ5EL1GEh0K";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 14) = "GENtZE9wZW5IaXBwbGVuQ3ljbGVDc1JlcRCqRkIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray16<string>, string>(ref buffer, 15) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray16<string>, string>(in buffer, 16))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdHipplenType) }, null, null));
	}
}
