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
		buffer[0] = "ChRDbWRIaXBwbGVuVHlwZS5wcm90byr5BAoOQ21kSGlwcGxlblR5cGUSGwoX";
		buffer[1] = "T0JKTE5PQ0ZCSU9fUENQREhFTFBLRU0QABIdChhDbWRTZXRIaXBwbGVuT3V0";
		buffer[2] = "Zml0Q3NSZXEQukYSJAofQ21kVGFrZUhpcHBsZW5FbmRpbmdSZXdhcmRDc1Jl";
		buffer[3] = "cRC4RhIeChlDbWRHZXRIaXBwbGVuSW5oZXJpdFNjUnNwEMNGEh4KGUNtZEdl";
		buffer[4] = "dEhpcHBsZW5Jbmhlcml0Q3NSZXEQxkYSIgodQ21kSGlwcGxlblRyYWl0VW5s";
		buffer[5] = "b2NrU2NOb3RpZnkQ2kYSHQoYQ21kU2V0SGlwcGxlbkFnZW5kYUNzUmVxEMtG";
		buffer[6] = "Eh4KGUNtZFNldHRsZUhpcHBsZW5Xb3JrQ3NSZXEQrUYSHQoYQ21kT3Blbkhp";
		buffer[7] = "cHBsZW5DeWNsZVNjUnNwENRGEiMKHkNtZEhpcHBsZW5BZ2VuZGFSZXN1bHRT";
		buffer[8] = "Y05vdGlmeRDXRhIbChZDbWRHZXRIaXBwbGVuRGF0YUNzUmVxELVGEh4KGUNt";
		buffer[9] = "ZFNldHRsZUhpcHBsZW5Xb3JrU2NSc3AQqUYSGwoWQ21kR2V0SGlwcGxlbkRh";
		buffer[10] = "dGFTY1JzcBCvRhIiCh1DbWRIaXBwbGVuQ3ljbGVSZXN1bHRTY05vdGlmeRC7";
		buffer[11] = "RhIdChhDbWRTZXRIaXBwbGVuT3V0Zml0U2NSc3AQ1UYSHQoYQ21kU2V0SGlw";
		buffer[12] = "cGxlbkFnZW5kYVNjUnNwEM5GEiQKH0NtZFRha2VIaXBwbGVuRW5kaW5nUmV3";
		buffer[13] = "YXJkU2NSc3AQx0YSHQoYQ21kSGlwcGxlbkNoYW5nZVNjTm90aWZ5EL1GEh0K";
		buffer[14] = "GENtZE9wZW5IaXBwbGVuQ3ljbGVDc1JlcRCqRkIWqgITTWFyY2g3dGhIb25l";
		buffer[15] = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(CmdHipplenType) }, null, null));
	}
}
