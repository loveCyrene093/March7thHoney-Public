using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateHouguSelectReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateHouguSelectReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChhGYXRlSG91Z3VTZWxlY3RSZXEucHJvdG8aEURPSkFDTkJDRUVILnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "GhFLT1BORlBQSUZDSS5wcm90byKFAQoSRmF0ZUhvdWd1U2VsZWN0UmVxEhYK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "DnF1ZXVlX3Bvc2l0aW9uGAwgASgNEiMKC0NJQ0dNTkhNTE1FGAYgASgLMgwu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "RE9KQUNOQkNFRUhIABIjCgtDT0hNR0dQSElIThgJIAEoCzIMLktPUE5GUFBJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "RkNJSABCDQoLSUhOTUhOUE1ISkdCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			DOJACNBCEEHReflection.Descriptor,
			KOPNFPPIFCIReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateHouguSelectReq), FateHouguSelectReq.Parser, new string[3] { "QueuePosition", "CICGMNHMLME", "COHMGGPHIHN" }, new string[1] { "IHNMHNPMHJG" }, null, null, null)
		}));
	}
}
