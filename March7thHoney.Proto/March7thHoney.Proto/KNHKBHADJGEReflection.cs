using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KNHKBHADJGEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KNHKBHADJGEReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFLTkhLQkhBREpHRS5wcm90bxoRQUhQQ0pQTU1FTU4ucHJvdG8aD1NwQmFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "SW5mby5wcm90byKWAQoLS05IS0JIQURKR0USEwoLSU1NSEpNREhER0MYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "KA0SEwoLSVBFQk1NUEtKTEYYAiABKA0SGgoGc3BfYmFyGAUgASgLMgouU3BC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "YXJJbmZvEhEKCXByb21vdGlvbhgJIAEoDRILCgNleHAYCiABKA0SIQoLT0tN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "RkVHRElPTkcYDiADKAsyDC5BSFBDSlBNTUVNTkIWqgITTWFyY2g3dGhIb25l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "eS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			AHPCJPMMEMNReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KNHKBHADJGE), KNHKBHADJGE.Parser, new string[6] { "IMMHJMDHDGC", "IPEBMMPKJLF", "SpBar", "Promotion", "Exp", "OKMFEGDIONG" }, null, null, null, null)
		}));
	}
}
