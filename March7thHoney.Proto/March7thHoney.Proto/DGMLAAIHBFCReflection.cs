using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DGMLAAIHBFCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DGMLAAIHBFCReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChFER01MQUFJSEJGQy5wcm90bxoRSE1FREJHQU1NUE4ucHJvdG8aEUlIR0JE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "QUdIRE1FLnByb3RvIoECCgtER01MQUFJSEJGQxIhCgtNUElJTExNTFBKThgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "IAMoCzIMLklIR0JEQUdIRE1FEjIKC0lJSEFEUEdFQUpCGAIgAygLMh0uREdN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "TEFBSUhCRkMuSUlIQURQR0VBSkJFbnRyeRIhCgtETk9QSEpGS0tIQxgJIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "CzIMLkhNRURCR0FNTVBOEiEKC0lQRlBESk5GTU1OGA0gASgLMgwuSE1FREJH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "QU1NUE4SEwoLTkVFRkFDSkJLUE4YDyABKA0aQAoQSUlIQURQR0VBSkJFbnRy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "eRILCgNrZXkYASABKA0SGwoFdmFsdWUYAiABKAsyDC5ITUVEQkdBTU1QTjoC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "OAFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			HMEDBGAMMPNReflection.Descriptor,
			IHGBDAGHDMEReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DGMLAAIHBFC), DGMLAAIHBFC.Parser, new string[5] { "MPIILLMLPJN", "IIHADPGEAJB", "DNOPHJFKKHC", "IPFPDJNFMMN", "NEEFACJBKPN" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
