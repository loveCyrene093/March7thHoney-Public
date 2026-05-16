using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlayerAssistInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlayerAssistInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChZQbGF5ZXJBc3Npc3RJbmZvLnByb3RvGh1EaXNwbGF5QXZhdGFyRGV0YWls";
		buffer[1] = "SW5mby5wcm90bxoWUGxheWVyU2ltcGxlSW5mby5wcm90byJrChBQbGF5ZXJB";
		buffer[2] = "c3Npc3RJbmZvEi8KDWFzc2lzdF9hdmF0YXIYCyABKAsyGC5EaXNwbGF5QXZh";
		buffer[3] = "dGFyRGV0YWlsSW5mbxImCgtwbGF5ZXJfaW5mbxgPIAEoCzIRLlBsYXllclNp";
		buffer[4] = "bXBsZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			DisplayAvatarDetailInfoReflection.Descriptor,
			PlayerSimpleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlayerAssistInfo), PlayerAssistInfo.Parser, new string[2] { "AssistAvatar", "PlayerInfo" }, null, null, null, null)
		}));
	}
}
