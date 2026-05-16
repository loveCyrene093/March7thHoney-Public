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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChRBdmF0YXJQYXRoRGF0YS5wcm90bxoZQXZhdGFyUGF0aFNraWxsVHJlZS5w";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "cm90bxoQRXF1aXBSZWxpYy5wcm90byL1AQoOQXZhdGFyUGF0aERhdGESNAoW";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "YXZhdGFyX3BhdGhfc2tpbGxfdHJlZRgBIAMoCzIULkF2YXRhclBhdGhTa2ls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "bFRyZWUSFwoPZHJlc3NlZF9za2luX2lkGAggASgNEiUKEGVxdWlwX3JlbGlj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "X2xpc3QYCSADKAsyCy5FcXVpcFJlbGljEhEKCWF2YXRhcl9pZBgKIAEoDRIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "CgRyYW5rGAsgASgNEhgKEHVubG9ja190aW1lc3RhbXAYDCABKAQSGQoRcGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "aF9lcXVpcG1lbnRfaWQYDSABKA0SFwoPdW5rX2VuaGFuY2VkX2lkGA4gASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[2]
		{
			AvatarPathSkillTreeReflection.Descriptor,
			EquipRelicReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarPathData), AvatarPathData.Parser, new string[8] { "AvatarPathSkillTree", "DressedSkinId", "EquipRelicList", "AvatarId", "Rank", "UnlockTimestamp", "PathEquipmentId", "UnkEnhancedId" }, null, null, null, null)
		}));
	}
}
