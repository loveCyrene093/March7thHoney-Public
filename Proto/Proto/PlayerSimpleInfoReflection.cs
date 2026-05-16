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
		buffer[0] = "ChZQbGF5ZXJTaW1wbGVJbmZvLnByb3RvGhZBc3Npc3RTaW1wbGVJbmZvLnBy";
		buffer[1] = "b3RvGhhGcmllbmRPbmxpbmVTdGF0dXMucHJvdG8aE0hlYWRGcmFtZUluZm8u";
		buffer[2] = "cHJvdG8aElBsYXRmb3JtVHlwZS5wcm90bxoWUGxheWVyT3V0Zml0SW5mby5w";
		buffer[3] = "cm90byLaAwoQUGxheWVyU2ltcGxlSW5mbxIQCghuaWNrbmFtZRgBIAEoCRIR";
		buffer[4] = "CglzaWduYXR1cmUYAiABKAkSFQoNcGxhdGZvcm1fdXVpZBgDIAEoCRItChJw";
		buffer[5] = "bGF5ZXJfb3V0Zml0X2RhdGEYBCABKAsyES5QbGF5ZXJPdXRmaXRJbmZvEgsK";
		buffer[6] = "A3VpZBgFIAEoDRIVCg1wbGF0Zm9ybV9uaWNrGAYgASgJEh8KCHBsYXRmb3Jt";
		buffer[7] = "GAcgASgOMg0uUGxhdGZvcm1UeXBlEhUKDXBlcnNvbmFsX2NhcmQYCCABKA0S";
		buffer[8] = "GAoQbGFzdF9hY3RpdmVfdGltZRgJIAEoAxIqCg1vbmxpbmVfc3RhdHVzGAog";
		buffer[9] = "ASgOMhMuRnJpZW5kT25saW5lU3RhdHVzEhYKDmNoYXRfYnViYmxlX2lkGAsg";
		buffer[10] = "ASgNEhEKCWhlYWRfaWNvbhgMIAEoDRIRCglpc19iYW5uZWQYDSABKAgSDQoF";
		buffer[11] = "bGV2ZWwYDiABKA0SMgoXYXNzaXN0X3NpbXBsZV9pbmZvX2xpc3QYDyADKAsy";
		buffer[12] = "ES5Bc3Npc3RTaW1wbGVJbmZvEicKD2hlYWRfZnJhbWVfaW5mbxhpIAEoCzIO";
		buffer[13] = "LkhlYWRGcmFtZUluZm8SDwoGZ2VuZGVyGPsKIAEoDUIWqgITTWFyY2g3dGhI";
		buffer[14] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[5]
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
