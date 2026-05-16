using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFriendListInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFriendListInfoScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChxHZXRGcmllbmRMaXN0SW5mb1NjUnNwLnByb3RvGhZGcmllbmRTaW1wbGVJ";
		buffer[1] = "bmZvLnByb3RvGhZQbGF5ZXJTaW1wbGVJbmZvLnByb3RvIngKFkdldEZyaWVu";
		buffer[2] = "ZExpc3RJbmZvU2NSc3ASDwoHcmV0Y29kZRgGIAEoDRIlCgpibGFja19saXN0";
		buffer[3] = "GAwgAygLMhEuUGxheWVyU2ltcGxlSW5mbxImCgtmcmllbmRfbGlzdBgPIAMo";
		buffer[4] = "CzIRLkZyaWVuZFNpbXBsZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[5] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			FriendSimpleInfoReflection.Descriptor,
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendListInfoScRsp), GetFriendListInfoScRsp.Parser, new string[3] { "Retcode", "BlackList", "FriendList" }, null, null, null, null)
		}));
	}
}
