using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MHGCNDDMIIJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MHGCNDDMIIJReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFNSEdDTkRETUlJSi5wcm90bxoRSkFOTk9FTUNLT0kucHJvdG8ifAoLTUhH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "Q05ERE1JSUoSEQoJbWF4X3Njb3JlGAMgASgNEhAKCHN0YWdlX2lkGAggASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EhAKCHBhbmVsX2lkGAsgASgNEhMKC1BQQ0tPRklMR05CGA4gASgNEiEKC0NF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "RkFESElGTklOGA8gASgLMgwuSkFOTk9FTUNLT0lCFqoCE01hcmNoN3RoSG9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { JANNOEMCKOIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MHGCNDDMIIJ), MHGCNDDMIIJ.Parser, new string[5] { "MaxScore", "StageId", "PanelId", "PPCKOFILGNB", "CEFADHIFNIN" }, null, null, null, null)
		}));
	}
}
