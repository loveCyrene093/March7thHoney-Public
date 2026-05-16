using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BigDataRecommendAvatarRelicReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BigDataRecommendAvatarRelicReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFCaWdEYXRhUmVjb21tZW5kQXZhdGFyUmVsaWMucHJvdG8aIUJpZ0RhdGFB";
		buffer[1] = "dmF0YXJSZWxpY1JlY29tbWVuZC5wcm90byJfChtCaWdEYXRhUmVjb21tZW5k";
		buffer[2] = "QXZhdGFyUmVsaWMSQAoacmVjb21lbmRlZF9yZWxpY19pbmZvX2xpc3QYDCAD";
		buffer[3] = "KAsyHC5CaWdEYXRhQXZhdGFyUmVsaWNSZWNvbW1lbmRCFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BigDataAvatarRelicRecommendReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BigDataRecommendAvatarRelic), BigDataRecommendAvatarRelic.Parser, new string[1] { "RecomendedRelicInfoList" }, null, null, null, null)
		}));
	}
}
