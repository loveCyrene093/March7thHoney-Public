using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelfRankChangeNtfReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelfRankChangeNtfReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChdTZWxmUmFua0NoYW5nZU50Zi5wcm90bxoRRUZCSUhKSE1JQ0IucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "E0ZpZ2h0R2FtZU1vZGUucHJvdG8iWwoRU2VsZlJhbmtDaGFuZ2VOdGYSIwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "UExPQk1CRlBORksYASABKA4yDi5GaWdodEdhbWVNb2RlEiEKC0NQQkdMTkdP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Q0JBGA4gAygLMgwuRUZCSUhKSE1JQ0JCFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			EFBIHJHMICBReflection.Descriptor,
			FightGameModeReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelfRankChangeNtf), SelfRankChangeNtf.Parser, new string[2] { "PLOBMBFPNFK", "CPBGLNGOCBA" }, null, null, null, null)
		}));
	}
}
