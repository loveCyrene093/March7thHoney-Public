using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarPathDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarPathDataReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChRBdmF0YXJQYXRoRGF0YS5wcm90bxoZQXZhdGFyUGF0aFNraWxsVHJlZS5w";
		buffer[1] = "cm90bxoQRXF1aXBSZWxpYy5wcm90byL1AQoOQXZhdGFyUGF0aERhdGESNAoW";
		buffer[2] = "YXZhdGFyX3BhdGhfc2tpbGxfdHJlZRgBIAMoCzIULkF2YXRhclBhdGhTa2ls";
		buffer[3] = "bFRyZWUSFwoPZHJlc3NlZF9za2luX2lkGAggASgNEiUKEGVxdWlwX3JlbGlj";
		buffer[4] = "X2xpc3QYCSADKAsyCy5FcXVpcFJlbGljEhEKCWF2YXRhcl9pZBgKIAEoDRIM";
		buffer[5] = "CgRyYW5rGAsgASgNEhgKEHVubG9ja190aW1lc3RhbXAYDCABKAQSGQoRcGF0";
		buffer[6] = "aF9lcXVpcG1lbnRfaWQYDSABKA0SFwoPdW5rX2VuaGFuY2VkX2lkGA4gASgN";
		buffer[7] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AvatarPathSkillTreeReflection.Descriptor,
			EquipRelicReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarPathData), AvatarPathData.Parser, new string[8] { "AvatarPathSkillTree", "DressedSkinId", "EquipRelicList", "AvatarId", "Rank", "UnlockTimestamp", "PathEquipmentId", "UnkEnhancedId" }, null, null, null, null)
		}));
	}
}
