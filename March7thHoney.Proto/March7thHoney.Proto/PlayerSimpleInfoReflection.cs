using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerSimpleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerSimpleInfoReflection()
	{
		InlineArray15<string> buffer = default(InlineArray15<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 0) = "ChZQbGF5ZXJTaW1wbGVJbmZvLnByb3RvGhZBc3Npc3RTaW1wbGVJbmZvLnBy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 1) = "b3RvGhhGcmllbmRPbmxpbmVTdGF0dXMucHJvdG8aE0hlYWRGcmFtZUluZm8u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 2) = "cHJvdG8aElBsYXRmb3JtVHlwZS5wcm90bxoWUGxheWVyT3V0Zml0SW5mby5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 3) = "cm90byLaAwoQUGxheWVyU2ltcGxlSW5mbxIQCghuaWNrbmFtZRgBIAEoCRIR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 4) = "CglzaWduYXR1cmUYAiABKAkSFQoNcGxhdGZvcm1fdXVpZBgDIAEoCRItChJw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 5) = "bGF5ZXJfb3V0Zml0X2RhdGEYBCABKAsyES5QbGF5ZXJPdXRmaXRJbmZvEgsK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 6) = "A3VpZBgFIAEoDRIVCg1wbGF0Zm9ybV9uaWNrGAYgASgJEh8KCHBsYXRmb3Jt";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 7) = "GAcgASgOMg0uUGxhdGZvcm1UeXBlEhUKDXBlcnNvbmFsX2NhcmQYCCABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 8) = "GAoQbGFzdF9hY3RpdmVfdGltZRgJIAEoAxIqCg1vbmxpbmVfc3RhdHVzGAog";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 9) = "ASgOMhMuRnJpZW5kT25saW5lU3RhdHVzEhYKDmNoYXRfYnViYmxlX2lkGAsg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 10) = "ASgNEhEKCWhlYWRfaWNvbhgMIAEoDRIRCglpc19iYW5uZWQYDSABKAgSDQoF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 11) = "bGV2ZWwYDiABKA0SMgoXYXNzaXN0X3NpbXBsZV9pbmZvX2xpc3QYDyADKAsy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 12) = "ES5Bc3Npc3RTaW1wbGVJbmZvEicKD2hlYWRfZnJhbWVfaW5mbxhpIAEoCzIO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 13) = "LkhlYWRGcmFtZUluZm8SDwoGZ2VuZGVyGPsKIAEoDUIWqgITTWFyY2g3dGhI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray15<string>, string>(ref buffer, 14) = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray15<string>, string>(in buffer, 15))), new FileDescriptor[5]
		{
			AssistSimpleInfoReflection.Descriptor,
			FriendOnlineStatusReflection.Descriptor,
			HeadFrameInfoReflection.Descriptor,
			PlatformTypeReflection.Descriptor,
			PlayerOutfitInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerSimpleInfo), PlayerSimpleInfo.Parser, new string[17]
			{
				"Nickname", "Signature", "PlatformUuid", "PlayerOutfitData", "Uid", "PlatformNick", "Platform", "PersonalCard", "LastActiveTime", "OnlineStatus",
				"ChatBubbleId", "HeadIcon", "IsBanned", "Level", "AssistSimpleInfoList", "HeadFrameInfo", "Gender"
			}, null, null, null, null)
		}));
	}
}
