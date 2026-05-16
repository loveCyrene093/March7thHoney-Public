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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChxHZXRGcmllbmRMaXN0SW5mb1NjUnNwLnByb3RvGhZGcmllbmRTaW1wbGVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bmZvLnByb3RvGhZQbGF5ZXJTaW1wbGVJbmZvLnByb3RvIngKFkdldEZyaWVu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "ZExpc3RJbmZvU2NSc3ASDwoHcmV0Y29kZRgGIAEoDRIlCgpibGFja19saXN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "GAwgAygLMhEuUGxheWVyU2ltcGxlSW5mbxImCgtmcmllbmRfbGlzdBgPIAMo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "CzIRLkZyaWVuZFNpbXBsZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			FriendSimpleInfoReflection.Descriptor,
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFriendListInfoScRsp), GetFriendListInfoScRsp.Parser, new string[3] { "Retcode", "BlackList", "FriendList" }, null, null, null, null)
		}));
	}
}
