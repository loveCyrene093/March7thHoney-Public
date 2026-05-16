using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LineupSlotDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LineupSlotDataReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChRMaW5ldXBTbG90RGF0YS5wcm90bxoQQXZhdGFyVHlwZS5wcm90byJgCg5M" + "aW5ldXBTbG90RGF0YRIMCgRzbG90GAMgASgNEiAKC2F2YXRhcl90eXBlGAQg" + "ASgOMgsuQXZhdGFyVHlwZRIKCgJpZBgHIAEoDRISCgphc3Npc3RfdWlkGA0g" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { AvatarTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LineupSlotData), LineupSlotData.Parser, new string[4] { "Slot", "AvatarType", "Id", "AssistUid" }, null, null, null, null)
		}));
	}
}
