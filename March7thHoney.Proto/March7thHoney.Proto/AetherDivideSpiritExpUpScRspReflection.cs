using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideSpiritExpUpScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideSpiritExpUpScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiJBZXRoZXJEaXZpZGVTcGlyaXRFeHBVcFNjUnNwLnByb3RvGhFLTkhLQkhB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "REpHRS5wcm90byJnChxBZXRoZXJEaXZpZGVTcGlyaXRFeHBVcFNjUnNwEiEK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "C0hLT0hJSENCR0FBGAEgASgLMgwuS05IS0JIQURKR0USEwoLRklLTExPQ0pC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "R04YAiABKA0SDwoHcmV0Y29kZRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { KNHKBHADJGEReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideSpiritExpUpScRsp), AetherDivideSpiritExpUpScRsp.Parser, new string[3] { "HKOHIHCBGAA", "FIKLLOCJBGN", "Retcode" }, null, null, null, null)
		}));
	}
}
