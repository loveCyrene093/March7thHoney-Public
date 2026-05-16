using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AssistSimpleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AssistSimpleInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZBc3Npc3RTaW1wbGVJbmZvLnByb3RvIloKEEFzc2lzdFNpbXBsZUluZm8S" + "CwoDcG9zGAIgASgNEhEKCWF2YXRhcl9pZBgDIAEoDRIXCg9kcmVzc2VkX3Nr" + "aW5faWQYCSABKA0SDQoFbGV2ZWwYDyABKA1CFqoCE01hcmNoN3RoSG9uZXku" + "UHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AssistSimpleInfo), AssistSimpleInfo.Parser, new string[4] { "Pos", "AvatarId", "DressedSkinId", "Level" }, null, null, null, null)
		}));
	}
}
