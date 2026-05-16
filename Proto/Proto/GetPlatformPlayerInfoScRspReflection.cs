using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlatformPlayerInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlatformPlayerInfoScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiBHZXRQbGF0Zm9ybVBsYXllckluZm9TY1JzcC5wcm90bxoWUGxheWVyU2lt";
		buffer[1] = "cGxlSW5mby5wcm90byJfChpHZXRQbGF0Zm9ybVBsYXllckluZm9TY1JzcBIP";
		buffer[2] = "CgdyZXRjb2RlGAYgASgNEjAKFWZyaWVuZF9yZWNvbW1lbmRfbGlzdBgOIAMo";
		buffer[3] = "CzIRLlBsYXllclNpbXBsZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PlayerSimpleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlatformPlayerInfoScRsp), GetPlatformPlayerInfoScRsp.Parser, new string[2] { "Retcode", "FriendRecommendList" }, null, null, null, null)
		}));
	}
}
