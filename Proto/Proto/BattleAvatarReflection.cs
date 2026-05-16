using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleAvatarReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleAvatarReflection()
	{
		InlineArray14<string> buffer = default(InlineArray14<string>);
		buffer[0] = "ChJCYXR0bGVBdmF0YXIucHJvdG8aEUFBS0hFTkhNSUZNLnByb3RvGhVBdmF0";
		buffer[1] = "YXJTa2lsbFRyZWUucHJvdG8aEEF2YXRhclR5cGUucHJvdG8aFUJhdHRsZUVx";
		buffer[2] = "dWlwbWVudC5wcm90bxoRQmF0dGxlUmVsaWMucHJvdG8aD1NwQmFySW5mby5w";
		buffer[3] = "cm90byK2AwoMQmF0dGxlQXZhdGFyEiAKC2F2YXRhcl90eXBlGAEgASgOMgsu";
		buffer[4] = "QXZhdGFyVHlwZRIKCgJpZBgCIAEoDRINCgVsZXZlbBgDIAEoDRIMCgRyYW5r";
		buffer[5] = "GAQgASgNEg0KBWluZGV4GAUgASgNEigKDnNraWxsdHJlZV9saXN0GAYgAygL";
		buffer[6] = "MhAuQXZhdGFyU2tpbGxUcmVlEigKDmVxdWlwbWVudF9saXN0GAcgAygLMhAu";
		buffer[7] = "QmF0dGxlRXF1aXBtZW50EgoKAmhwGAggASgNEhEKCXByb21vdGlvbhgKIAEo";
		buffer[8] = "DRIgCgpyZWxpY19saXN0GAsgAygLMgwuQmF0dGxlUmVsaWMSEwoLd29ybGRf";
		buffer[9] = "bGV2ZWwYDCABKA0SEgoKYXNzaXN0X3VpZBgNIAEoDRIhCgtBS05IT05EQk5N";
		buffer[10] = "TRgPIAEoCzIMLkFBS0hFTkhNSUZNEhoKBnNwX2JhchgQIAEoCzIKLlNwQmFy";
		buffer[11] = "SW5mbxITCgtQSkxBREdPT0ZLRRgRIAEoDRIlCgtMRlBPQU9GQkdQShgSIAMo";
		buffer[12] = "CzIQLkF2YXRhclNraWxsVHJlZRITCgtlbmhhbmNlZF9pZBgTIAEoDUIWqgIT";
		buffer[13] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[6]
		{
			AAKHENHMIFMReflection.Descriptor,
			AvatarSkillTreeReflection.Descriptor,
			AvatarTypeReflection.Descriptor,
			BattleEquipmentReflection.Descriptor,
			BattleRelicReflection.Descriptor,
			SpBarInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleAvatar), BattleAvatar.Parser, new string[17]
			{
				"AvatarType", "Id", "Level", "Rank", "Index", "SkilltreeList", "EquipmentList", "Hp", "Promotion", "RelicList",
				"WorldLevel", "AssistUid", "AKNHONDBNMM", "SpBar", "PJLADGOOFKE", "LFPOAOFBGPJ", "EnhancedId"
			}, null, null, null, null)
		}));
	}
}
