using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BigDataRecommendRelicAvatarReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BigDataRecommendRelicAvatarReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiFCaWdEYXRhUmVjb21tZW5kUmVsaWNBdmF0YXIucHJvdG8aGlJlY29tZW5k";
		buffer[1] = "ZWRBdmF0YXJJbmZvLnByb3RvIloKG0JpZ0RhdGFSZWNvbW1lbmRSZWxpY0F2";
		buffer[2] = "YXRhchI7ChxyZWNvbW1lbmRlZF9hdmF0YXJfaW5mb19saXN0GAMgAygLMhUu";
		buffer[3] = "UmVjb21lbmRlZEF2YXRhckluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { RecomendedAvatarInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BigDataRecommendRelicAvatar), BigDataRecommendRelicAvatar.Parser, new string[1] { "RecommendedAvatarInfoList" }, null, null, null, null)
		}));
	}
}
