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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 0) = "ChZBdmF0YXJCYXR0bGVJbmZvLnByb3RvGhpBdHRhY2tEYW1hZ2VQcm9wZXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 1) = "eS5wcm90bxoUQXZhdGFyUHJvcGVydHkucHJvdG8aFUF2YXRhclNraWxsVHJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 2) = "ZS5wcm90bxoQQXZhdGFyVHlwZS5wcm90bxoRQmF0dGxlUmVsaWMucHJvdG8a";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 3) = "EURITkZHSkJITUFBLnByb3RvGhdFcXVpcG1lbnRQcm9wZXJ0eS5wcm90bxoR";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 4) = "SEJGQU1MTEhGQUYucHJvdG8aEU9FTU9DRkpMR0ZJLnByb3RvGhZTa2lsbFVz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 5) = "ZVByb3BlcnR5LnByb3RvGhFTcEFkZFNvdXJjZS5wcm90byKnDAoQQXZhdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 6) = "QmF0dGxlSW5mbxIgCgthdmF0YXJfdHlwZRgBIAEoDjILLkF2YXRhclR5cGUS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 7) = "CgoCaWQYAiABKA0SFAoMYXZhdGFyX2xldmVsGAMgASgNEhMKC2F2YXRhcl9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 8) = "YW5rGAQgASgNEhgKEGF2YXRhcl9wcm9tb3Rpb24YBSABKA0SJgoNYXZhdGFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 9) = "X3N0YXR1cxgGIAEoCzIPLkF2YXRhclByb3BlcnR5EiYKDGF2YXRhcl9za2ls";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 10) = "bBgHIAMoCzIQLkF2YXRhclNraWxsVHJlZRIsChBhdmF0YXJfZXF1aXBtZW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 11) = "GAggAygLMhIuRXF1aXBtZW50UHJvcGVydHkSEwoLdG90YWxfdHVybnMYCSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 12) = "KA0SFAoMdG90YWxfZGFtYWdlGAogASgBEhIKCnRvdGFsX2hlYWwYCyABKAES";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 13) = "GgoSdG90YWxfZGFtYWdlX3Rha2VuGAwgASgBEhgKEHRvdGFsX2hwX3JlY292";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 14) = "ZXIYDSABKAESFQoNdG90YWxfc3BfY29zdBgOIAEoARIQCghzdGFnZV9pZBgP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 15) = "IAEoDRISCgpzdGFnZV90eXBlGBAgASgNEhoKEnRvdGFsX2JyZWFrX2RhbWFn";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 16) = "ZRgRIAEoARIxChJhdHRhY2tfdHlwZV9kYW1hZ2UYEiADKAsyFS5BdHRhY2tE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 17) = "YW1hZ2VQcm9wZXJ0eRI3ChhhdHRhY2tfdHlwZV9icmVha19kYW1hZ2UYEyAD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 18) = "KAsyFS5BdHRhY2tEYW1hZ2VQcm9wZXJ0eRI1ChZhdHRhY2tfdHlwZV9tYXhf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 19) = "ZGFtYWdlGBQgAygLMhUuQXR0YWNrRGFtYWdlUHJvcGVydHkSJgoLc2tpbGxf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 20) = "dGltZXMYFSADKAsyES5Ta2lsbFVzZVByb3BlcnR5EhYKDmRlbGF5X2N1bXVs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 21) = "YXRlGBYgASgBEhQKDHRvdGFsX3NwX2FkZBgXIAEoDRIjCg1zcF9hZGRfc291";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 22) = "cmNlGBggAygLMgwuU3BBZGRTb3VyY2USFQoNdG90YWxfYnBfY29zdBgZIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 23) = "DRIRCglkaWVfdGltZXMYGiABKA0SFAoMcmV2aXZlX3RpbWVzGBsgASgNEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 24) = "C2JyZWFrX3RpbWVzGBwgASgNEhMKC2V4dHJhX3R1cm5zGB0gASgNEhQKDHRv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 25) = "dGFsX3NoaWVsZBgeIAEoARIaChJ0b3RhbF9zaGllbGRfdGFrZW4YHyABKAES";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 26) = "GwoTdG90YWxfc2hpZWxkX2RhbWFnZRggIAEoARInCg5pbml0aWFsX3N0YXR1";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 27) = "cxghIAEoCzIPLkF2YXRhclByb3BlcnR5EhwKBnJlbGljcxgiIAMoCzIMLkJh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 28) = "dHRsZVJlbGljEhIKCmFzc2lzdF91aWQYIyABKA0SKgoLSExPT0ZLTEVMTEoY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 29) = "JCADKAsyFS5BdHRhY2tEYW1hZ2VQcm9wZXJ0eRITCgtPRUpQS0pQTUtCQxgl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 30) = "IAEoARITCgtPR0RHRUtGSkFGTxgmIAEoARITCgtBR0xLUElKS0tHThgnIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 31) = "ARITCgtLT05NR0JKQklFQRgoIAEoARIhCgtHREFIQ0dDS09CTxgpIAMoCzIM";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 32) = "Lk9FTU9DRkpMR0ZJEhMKC0hPT0ZFTUVLS09CGCogASgNEhMKC0RPQVBCT0xK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 33) = "T0dGGCsgASgNEhMKC0ZKTElITURFTk1MGCwgASgBEhMKC0xMQ05PQ0dISk9P";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 34) = "GC0gASgBEhMKC0dGQkxOQUVIUENIGC4gASgBEhMKC0tOR09DSEdFTENFGC8g";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 35) = "ASgBEhMKC0ZPREtNQk5MQ0tBGDAgASgBEhMKC0xOSUhBTEZBQUdBGDEgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 36) = "EhMKC0JFTkpGTk5PREVGGDIgASgNEhMKC0xCTEFKSkFGRkJIGDMgASgNEhMK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 37) = "C0RQREFBSUhER0FBGDQgASgBEhMKC01HT0hCT0tKQktEGDUgASgNEhMKC0hN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 38) = "SUZPRkRNQ0NDGDYgASgNEhMKC2VuaGFuY2VkX2lkGDcgASgNEhMKC0FOTUJB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 39) = "SUZPQkpQGDggASgNEiEKC05PRERETkpBQUxQGDkgASgLMgwuSEJGQU1MTEhG";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 40) = "QUYSIQoLTU5ISUpESkJLTEIYOiABKAsyDC5ESE5GR0pCSE1BQUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray42<string>, string>(ref buffer, 41) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray42<string>, string>(in buffer, 42))), new FileDescriptor[11]
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
