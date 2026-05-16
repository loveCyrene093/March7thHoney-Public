using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarBattleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarBattleInfoReflection()
	{
		_003C_003Ey__InlineArray42<string> buffer = default(_003C_003Ey__InlineArray42<string>);
		buffer[0] = "ChZBdmF0YXJCYXR0bGVJbmZvLnByb3RvGhpBdHRhY2tEYW1hZ2VQcm9wZXJ0";
		buffer[1] = "eS5wcm90bxoUQXZhdGFyUHJvcGVydHkucHJvdG8aFUF2YXRhclNraWxsVHJl";
		buffer[2] = "ZS5wcm90bxoQQXZhdGFyVHlwZS5wcm90bxoRQmF0dGxlUmVsaWMucHJvdG8a";
		buffer[3] = "EURITkZHSkJITUFBLnByb3RvGhdFcXVpcG1lbnRQcm9wZXJ0eS5wcm90bxoR";
		buffer[4] = "SEJGQU1MTEhGQUYucHJvdG8aEU9FTU9DRkpMR0ZJLnByb3RvGhZTa2lsbFVz";
		buffer[5] = "ZVByb3BlcnR5LnByb3RvGhFTcEFkZFNvdXJjZS5wcm90byKnDAoQQXZhdGFy";
		buffer[6] = "QmF0dGxlSW5mbxIgCgthdmF0YXJfdHlwZRgBIAEoDjILLkF2YXRhclR5cGUS";
		buffer[7] = "CgoCaWQYAiABKA0SFAoMYXZhdGFyX2xldmVsGAMgASgNEhMKC2F2YXRhcl9y";
		buffer[8] = "YW5rGAQgASgNEhgKEGF2YXRhcl9wcm9tb3Rpb24YBSABKA0SJgoNYXZhdGFy";
		buffer[9] = "X3N0YXR1cxgGIAEoCzIPLkF2YXRhclByb3BlcnR5EiYKDGF2YXRhcl9za2ls";
		buffer[10] = "bBgHIAMoCzIQLkF2YXRhclNraWxsVHJlZRIsChBhdmF0YXJfZXF1aXBtZW50";
		buffer[11] = "GAggAygLMhIuRXF1aXBtZW50UHJvcGVydHkSEwoLdG90YWxfdHVybnMYCSAB";
		buffer[12] = "KA0SFAoMdG90YWxfZGFtYWdlGAogASgBEhIKCnRvdGFsX2hlYWwYCyABKAES";
		buffer[13] = "GgoSdG90YWxfZGFtYWdlX3Rha2VuGAwgASgBEhgKEHRvdGFsX2hwX3JlY292";
		buffer[14] = "ZXIYDSABKAESFQoNdG90YWxfc3BfY29zdBgOIAEoARIQCghzdGFnZV9pZBgP";
		buffer[15] = "IAEoDRISCgpzdGFnZV90eXBlGBAgASgNEhoKEnRvdGFsX2JyZWFrX2RhbWFn";
		buffer[16] = "ZRgRIAEoARIxChJhdHRhY2tfdHlwZV9kYW1hZ2UYEiADKAsyFS5BdHRhY2tE";
		buffer[17] = "YW1hZ2VQcm9wZXJ0eRI3ChhhdHRhY2tfdHlwZV9icmVha19kYW1hZ2UYEyAD";
		buffer[18] = "KAsyFS5BdHRhY2tEYW1hZ2VQcm9wZXJ0eRI1ChZhdHRhY2tfdHlwZV9tYXhf";
		buffer[19] = "ZGFtYWdlGBQgAygLMhUuQXR0YWNrRGFtYWdlUHJvcGVydHkSJgoLc2tpbGxf";
		buffer[20] = "dGltZXMYFSADKAsyES5Ta2lsbFVzZVByb3BlcnR5EhYKDmRlbGF5X2N1bXVs";
		buffer[21] = "YXRlGBYgASgBEhQKDHRvdGFsX3NwX2FkZBgXIAEoDRIjCg1zcF9hZGRfc291";
		buffer[22] = "cmNlGBggAygLMgwuU3BBZGRTb3VyY2USFQoNdG90YWxfYnBfY29zdBgZIAEo";
		buffer[23] = "DRIRCglkaWVfdGltZXMYGiABKA0SFAoMcmV2aXZlX3RpbWVzGBsgASgNEhMK";
		buffer[24] = "C2JyZWFrX3RpbWVzGBwgASgNEhMKC2V4dHJhX3R1cm5zGB0gASgNEhQKDHRv";
		buffer[25] = "dGFsX3NoaWVsZBgeIAEoARIaChJ0b3RhbF9zaGllbGRfdGFrZW4YHyABKAES";
		buffer[26] = "GwoTdG90YWxfc2hpZWxkX2RhbWFnZRggIAEoARInCg5pbml0aWFsX3N0YXR1";
		buffer[27] = "cxghIAEoCzIPLkF2YXRhclByb3BlcnR5EhwKBnJlbGljcxgiIAMoCzIMLkJh";
		buffer[28] = "dHRsZVJlbGljEhIKCmFzc2lzdF91aWQYIyABKA0SKgoLSExPT0ZLTEVMTEoY";
		buffer[29] = "JCADKAsyFS5BdHRhY2tEYW1hZ2VQcm9wZXJ0eRITCgtPRUpQS0pQTUtCQxgl";
		buffer[30] = "IAEoARITCgtPR0RHRUtGSkFGTxgmIAEoARITCgtBR0xLUElKS0tHThgnIAEo";
		buffer[31] = "ARITCgtLT05NR0JKQklFQRgoIAEoARIhCgtHREFIQ0dDS09CTxgpIAMoCzIM";
		buffer[32] = "Lk9FTU9DRkpMR0ZJEhMKC0hPT0ZFTUVLS09CGCogASgNEhMKC0RPQVBCT0xK";
		buffer[33] = "T0dGGCsgASgNEhMKC0ZKTElITURFTk1MGCwgASgBEhMKC0xMQ05PQ0dISk9P";
		buffer[34] = "GC0gASgBEhMKC0dGQkxOQUVIUENIGC4gASgBEhMKC0tOR09DSEdFTENFGC8g";
		buffer[35] = "ASgBEhMKC0ZPREtNQk5MQ0tBGDAgASgBEhMKC0xOSUhBTEZBQUdBGDEgASgN";
		buffer[36] = "EhMKC0JFTkpGTk5PREVGGDIgASgNEhMKC0xCTEFKSkFGRkJIGDMgASgNEhMK";
		buffer[37] = "C0RQREFBSUhER0FBGDQgASgBEhMKC01HT0hCT0tKQktEGDUgASgNEhMKC0hN";
		buffer[38] = "SUZPRkRNQ0NDGDYgASgNEhMKC2VuaGFuY2VkX2lkGDcgASgNEhMKC0FOTUJB";
		buffer[39] = "SUZPQkpQGDggASgNEiEKC05PRERETkpBQUxQGDkgASgLMgwuSEJGQU1MTEhG";
		buffer[40] = "QUYSIQoLTU5ISUpESkJLTEIYOiABKAsyDC5ESE5GR0pCSE1BQUIWqgITTWFy";
		buffer[41] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[11]
		{
			AttackDamagePropertyReflection.Descriptor,
			AvatarPropertyReflection.Descriptor,
			AvatarSkillTreeReflection.Descriptor,
			AvatarTypeReflection.Descriptor,
			BattleRelicReflection.Descriptor,
			DHNFGJBHMAAReflection.Descriptor,
			EquipmentPropertyReflection.Descriptor,
			HBFAMLLHFAFReflection.Descriptor,
			OEMOCFJLGFIReflection.Descriptor,
			SkillUsePropertyReflection.Descriptor,
			SpAddSourceReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarBattleInfo), AvatarBattleInfo.Parser, new string[58]
			{
				"AvatarType", "Id", "AvatarLevel", "AvatarRank", "AvatarPromotion", "AvatarStatus", "AvatarSkill", "AvatarEquipment", "TotalTurns", "TotalDamage",
				"TotalHeal", "TotalDamageTaken", "TotalHpRecover", "TotalSpCost", "StageId", "StageType", "TotalBreakDamage", "AttackTypeDamage", "AttackTypeBreakDamage", "AttackTypeMaxDamage",
				"SkillTimes", "DelayCumulate", "TotalSpAdd", "SpAddSource", "TotalBpCost", "DieTimes", "ReviveTimes", "BreakTimes", "ExtraTurns", "TotalShield",
				"TotalShieldTaken", "TotalShieldDamage", "InitialStatus", "Relics", "AssistUid", "HLOOFKLELLJ", "OEJPKJPMKBC", "OGDGEKFJAFO", "AGLKPIJKKGN", "KONMGBJBIEA",
				"GDAHCGCKOBO", "HOOFEMEKKOB", "DOAPBOLJOGF", "FJLIHMDENML", "LLCNOCGHJOO", "GFBLNAEHPCH", "KNGOCHGELCE", "FODKMBNLCKA", "LNIHALFAAGA", "BENJFNNODEF",
				"LBLAJJAFFBH", "DPDAAIHDGAA", "MGOHBOKJBKD", "HMIFOFDMCCC", "EnhancedId", "ANMBAIFOBJP", "NODDDNJAALP", "MNHIJDJBKLB"
			}, null, null, null, null)
		}));
	}
}
