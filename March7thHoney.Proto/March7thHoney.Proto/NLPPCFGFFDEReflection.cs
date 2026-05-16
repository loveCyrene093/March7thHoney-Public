using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NLPPCFGFFDEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NLPPCFGFFDEReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "ChFOTFBQQ0ZHRkZERS5wcm90bxoRREdESEJBR0VPT0kucHJvdG8aEU9GQk5G";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "TkZHREZKLnByb3RvInYKC05MUFBDRkdGRkRFEg8KB2FyZWFfaWQYBiABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "EAoIcGFuZWxfaWQYCSABKA0SIQoLQkhJTEJJSkNET0UYCiABKAsyDC5PRkJO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "Rk5GR0RGShIhCgtCTk9DRVBLTVBHSxgOIAEoCzIMLkRHREhCQUdFT09JQhaq";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[2]
		{
			DGDHBAGEOOIReflection.Descriptor,
			OFBNFNFGDFJReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NLPPCFGFFDE), NLPPCFGFFDE.Parser, new string[4] { "AreaId", "PanelId", "BHILBIJCDOE", "BNOCEPKMPGK" }, null, null, null, null)
		}));
	}
}
