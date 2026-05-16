using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GachaInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GachaInfoReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "Cg9HYWNoYUluZm8ucHJvdG8aEkdhY2hhQ2VpbGluZy5wcm90byKZAgoJR2Fj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "aGFJbmZvEhAKCGVuZF90aW1lGAIgASgDEhIKCmJlZ2luX3RpbWUYAyABKAMS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "GAoQaXRlbV9kZXRhaWxfbGlzdBgGIAMoDRIQCghnYWNoYV9pZBgHIAEoDRIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "CgtQQVBPS0FDSVBQShgIIAEoDRITCgtDQkhBRUZOQUZMRRgJIAMoDRISCgpk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "ZXRhaWxfdXJsGAogASgJEhcKD3ByaXplX2l0ZW1fbGlzdBgLIAMoDRITCgto";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "aXN0b3J5X3VybBgMIAEoCRITCgtGSklCT0FHRE5ERxgNIAEoDRITCgtPS0ZO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "TkhOTEJPTxgOIAEoDRIkCg1nYWNoYV9jZWlsaW5nGA8gASgLMg0uR2FjaGFD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "ZWlsaW5nQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[1] { GachaCeilingReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GachaInfo), GachaInfo.Parser, new string[12]
			{
				"EndTime", "BeginTime", "ItemDetailList", "GachaId", "PAPOKACIPPJ", "CBHAEFNAFLE", "DetailUrl", "PrizeItemList", "HistoryUrl", "FJIBOAGDNDG",
				"OKFNNHNLBOO", "GachaCeiling"
			}, null, null, null, null)
		}));
	}
}
