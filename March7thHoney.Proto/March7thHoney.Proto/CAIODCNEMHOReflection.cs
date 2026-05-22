using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CAIODCNEMHOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CAIODCNEMHOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChFDQUlPRENORU1ITy5wcm90byLIAQoLQ0FJT0RDTkVNSE8SEwoLSUdOTkdK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "TUVCSEsYAiABKA0SEwoLREtIS0JCTVBDSUMYAyABKA0SEwoLSEVGRk1HQUlL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "TU4YBSABKA0SEQoJYXZhdGFyX2lkGAYgASgNEhMKC0FFQktFTURBQ0JNGAcg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgNEhMKC0pGTElHTkNBQUVKGAkgASgIEhMKC0FJSE5LUE9HQ0ZJGAogASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "EhMKC0lIT09OR1BMTEhKGAwgASgIEhMKC0lEQVBQSUJQSEhIGA4gASgBQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CAIODCNEMHO), CAIODCNEMHO.Parser, new string[9] { "IGNNGJMEBHK", "DKHKBBMPCIC", "HEFFMGAIKMN", "AvatarId", "AEBKEMDACBM", "JFLIGNCAAEJ", "AIHNKPOGCFI", "IHOONGPLLHJ", "IDAPPIBPHHH" }, null, null, null, null)
		}));
	}
}
