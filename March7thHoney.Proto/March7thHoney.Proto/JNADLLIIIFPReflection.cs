using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JNADLLIIIFPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JNADLLIIIFPReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFKTkFETExJSUlGUC5wcm90bxoRS09NQk9NSkJISkcucHJvdG8ibwoLSk5B";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "RExMSUlJRlASEwoLTUJKQ0NLTE5JQk0YASABKA0SEwoLSEVITUNBTkRLSksY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "AiABKA0SEwoLTENQT0tFUE5ERUsYAyABKA0SIQoLR0NNRU9EQ05HSUwYBCAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "KAsyDC5LT01CT01KQkhKR0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { KOMBOMJBHJGReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JNADLLIIIFP), JNADLLIIIFP.Parser, new string[4] { "MBJCCKLNIBM", "HEHMCANDKJK", "LCPOKEPNDEK", "GCMEODCNGIL" }, null, null, null, null)
		}));
	}
}
