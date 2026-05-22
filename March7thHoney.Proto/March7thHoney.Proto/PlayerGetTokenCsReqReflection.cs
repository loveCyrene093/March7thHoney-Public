using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerGetTokenCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerGetTokenCsReqReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChlQbGF5ZXJHZXRUb2tlbkNzUmVxLnByb3RvIscBChNQbGF5ZXJHZXRUb2tl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bkNzUmVxEhMKC2FjY291bnRfdWlkGAIgASgJEhcKD2FjY291bnRfaXBfcG9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "dBgDIAEoDRISCgphY2NvdW50X2lwGAQgASgNEhMKC0VGS0NNRklKR0lKGAUg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "ASgNEhgKEGFjY291bnRfdWlkX2VycjEYBiABKAkSDQoFdG9rZW4YByABKAkS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "CwoDdWlkGAggASgNEhAKCHBsYXRmb3JtGAogASgNEhEKCXNpZ25fdHlwZRgP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerGetTokenCsReq), PlayerGetTokenCsReq.Parser, new string[9] { "AccountUid", "AccountIpPort", "AccountIp", "EFKCMFIJGIJ", "AccountUidErr1", "Token", "Uid", "Platform", "SignType" }, null, null, null, null)
		}));
	}
}
