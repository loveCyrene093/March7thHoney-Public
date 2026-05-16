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
		buffer[0] = "Cg9HYWNoYUluZm8ucHJvdG8aEkdhY2hhQ2VpbGluZy5wcm90byKZAgoJR2Fj";
		buffer[1] = "aGFJbmZvEhAKCGVuZF90aW1lGAIgASgDEhIKCmJlZ2luX3RpbWUYAyABKAMS";
		buffer[2] = "GAoQaXRlbV9kZXRhaWxfbGlzdBgGIAMoDRIQCghnYWNoYV9pZBgHIAEoDRIT";
		buffer[3] = "CgtQQVBPS0FDSVBQShgIIAEoDRITCgtDQkhBRUZOQUZMRRgJIAMoDRISCgpk";
		buffer[4] = "ZXRhaWxfdXJsGAogASgJEhcKD3ByaXplX2l0ZW1fbGlzdBgLIAMoDRITCgto";
		buffer[5] = "aXN0b3J5X3VybBgMIAEoCRITCgtGSklCT0FHRE5ERxgNIAEoDRITCgtPS0ZO";
		buffer[6] = "TkhOTEJPTxgOIAEoDRIkCg1nYWNoYV9jZWlsaW5nGA8gASgLMg0uR2FjaGFD";
		buffer[7] = "ZWlsaW5nQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GachaCeilingReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GachaInfo), GachaInfo.Parser, new string[12]
			{
				"EndTime", "BeginTime", "ItemDetailList", "GachaId", "PAPOKACIPPJ", "CBHAEFNAFLE", "DetailUrl", "PrizeItemList", "HistoryUrl", "FJIBOAGDNDG",
				"OKFNNHNLBOO", "GachaCeiling"
			}, null, null, null, null)
		}));
	}
}
