using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HOBCIOKKNKHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HOBCIOKKNKHReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFIT0JDSU9LS05LSC5wcm90bxofQ2hpbWVyYUR1ZWxQbGF5ZXJSYW5rRGF0";
		buffer[1] = "YS5wcm90bxoRRERKT0VJQk9FTEgucHJvdG8iiwEKC0hPQkNJT0tLTktIEhMK";
		buffer[2] = "C01BUEROTEJISENEGAQgASgNEiEKC09JQVBIQkJEUEhMGAYgASgLMgwuRERK";
		buffer[3] = "T0VJQk9FTEgSLwoLR0VQR0dHREtCTksYCSABKAsyGi5DaGltZXJhRHVlbFBs";
		buffer[4] = "YXllclJhbmtEYXRhEhMKC0dJTERNUEtGR0dDGA8gASgIQhaqAhNNYXJjaDd0";
		buffer[5] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ChimeraDuelPlayerRankDataReflection.Descriptor,
			DDJOEIBOELHReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HOBCIOKKNKH), HOBCIOKKNKH.Parser, new string[4] { "MAPDNLBHHCD", "OIAPHBBDPHL", "GEPGGGDKBNK", "GILDMPKFGGC" }, null, null, null, null)
		}));
	}
}
