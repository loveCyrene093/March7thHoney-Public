using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DisplayAvatarDetailInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DisplayAvatarDetailInfoReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		buffer[0] = "Ch1EaXNwbGF5QXZhdGFyRGV0YWlsSW5mby5wcm90bxoVQXZhdGFyU2tpbGxU";
		buffer[1] = "cmVlLnByb3RvGhpEaXNwbGF5RXF1aXBtZW50SW5mby5wcm90bxoWRGlzcGxh";
		buffer[2] = "eVJlbGljSW5mby5wcm90byKfAgoXRGlzcGxheUF2YXRhckRldGFpbEluZm8S";
		buffer[3] = "FwoPZHJlc3NlZF9za2luX2lkGAEgASgNEgwKBHJhbmsYAiABKA0SCwoDcG9z";
		buffer[4] = "GAUgASgNEg0KBWxldmVsGAcgASgNEgsKA2V4cBgIIAEoDRITCgtlbmhhbmNl";
		buffer[5] = "ZF9pZBgJIAEoDRIoCg5za2lsbHRyZWVfbGlzdBgLIAMoCzIQLkF2YXRhclNr";
		buffer[6] = "aWxsVHJlZRIoCgllcXVpcG1lbnQYDCABKAsyFS5EaXNwbGF5RXF1aXBtZW50";
		buffer[7] = "SW5mbxIlCgpyZWxpY19saXN0GA0gAygLMhEuRGlzcGxheVJlbGljSW5mbxIR";
		buffer[8] = "CglhdmF0YXJfaWQYDiABKA0SEQoJcHJvbW90aW9uGA8gASgNQhaqAhNNYXJj";
		buffer[9] = "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			AvatarSkillTreeReflection.Descriptor,
			DisplayEquipmentInfoReflection.Descriptor,
			DisplayRelicInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DisplayAvatarDetailInfo), DisplayAvatarDetailInfo.Parser, new string[11]
			{
				"DressedSkinId", "Rank", "Pos", "Level", "Exp", "EnhancedId", "SkilltreeList", "Equipment", "RelicList", "AvatarId",
				"Promotion"
			}, null, null, null, null)
		}));
	}
}
