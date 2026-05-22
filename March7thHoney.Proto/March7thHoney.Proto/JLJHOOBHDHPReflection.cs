using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JLJHOOBHDHPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JLJHOOBHDHPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFKTEpIT09CSERIUC5wcm90bxoUR3JvdXBTdGF0ZUluZm8ucHJvdG8aEE1v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "dGlvbkluZm8ucHJvdG8idgoLSkxKSE9PQkhESFASKQoQZ3JvdXBfc3RhdGVf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "aW5mbxgEIAEoCzIPLkdyb3VwU3RhdGVJbmZvEgoKAmlkGAggASgNEhsKBm1v";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "dGlvbhgJIAEoCzILLk1vdGlvbkluZm8SEwoLTENIQUhFQ0pQT0kYCiABKAhC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			GroupStateInfoReflection.Descriptor,
			MotionInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JLJHOOBHDHP), JLJHOOBHDHP.Parser, new string[4] { "GroupStateInfo", "Id", "Motion", "LCHAHECJPOI" }, null, null, null, null)
		}));
	}
}
