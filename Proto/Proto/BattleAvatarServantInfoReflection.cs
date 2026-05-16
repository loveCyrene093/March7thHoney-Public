using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleAvatarServantInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleAvatarServantInfoReflection()
	{
		_003C_003Ey__InlineArray18<string> buffer = default(_003C_003Ey__InlineArray18<string>);
		buffer[0] = "Ch1CYXR0bGVBdmF0YXJTZXJ2YW50SW5mby5wcm90bxoaQXR0YWNrRGFtYWdl";
		buffer[1] = "UHJvcGVydHkucHJvdG8aFlNraWxsVXNlUHJvcGVydHkucHJvdG8ipwUKF0Jh";
		buffer[2] = "dHRsZUF2YXRhclNlcnZhbnRJbmZvEhEKCWF2YXRhcl9pZBgBIAEoDRITCgtG";
		buffer[3] = "SUZIS05IRUlCRBgCIAEoDRITCgt0b3RhbF90dXJucxgDIAEoDRITCgtORkVI";
		buffer[4] = "R0VQTFBBShgEIAEoARImCgtza2lsbF90aW1lcxgFIAMoCzIRLlNraWxsVXNl";
		buffer[5] = "UHJvcGVydHkSFAoMdG90YWxfZGFtYWdlGAYgASgBEhoKEnRvdGFsX2JyZWFr";
		buffer[6] = "X2RhbWFnZRgHIAEoARIxChJhdHRhY2tfdHlwZV9kYW1hZ2UYCCADKAsyFS5B";
		buffer[7] = "dHRhY2tEYW1hZ2VQcm9wZXJ0eRI3ChhhdHRhY2tfdHlwZV9icmVha19kYW1h";
		buffer[8] = "Z2UYCSADKAsyFS5BdHRhY2tEYW1hZ2VQcm9wZXJ0eRI1ChZhdHRhY2tfdHlw";
		buffer[9] = "ZV9tYXhfZGFtYWdlGAogAygLMhUuQXR0YWNrRGFtYWdlUHJvcGVydHkSGgoS";
		buffer[10] = "dG90YWxfZGFtYWdlX3Rha2VuGAsgASgBEhIKCnRvdGFsX2hlYWwYDCABKAES";
		buffer[11] = "GAoQdG90YWxfaHBfcmVjb3ZlchgNIAEoARIUCgx0b3RhbF9zaGllbGQYDiAB";
		buffer[12] = "KAESGgoSdG90YWxfc2hpZWxkX3Rha2VuGA8gASgBEhsKE3RvdGFsX3NoaWVs";
		buffer[13] = "ZF9kYW1hZ2UYECABKAESEwoLYnJlYWtfdGltZXMYESABKA0SEwoLQ0VITExO";
		buffer[14] = "Q0VNRE4YEiABKA0SEwoLSE9PRkVNRUtLT0IYEyABKA0SEwoLRE9BUEJPTEpP";
		buffer[15] = "R0YYFCABKA0SEwoLRkpMSUhNREVOTUwYFSABKAESEQoJZW50aXR5X2lkGBYg";
		buffer[16] = "ASgNEhMKC0FOTUJBSUZPQkpQGBcgASgNEhMKC09HREdFS0ZKQUZPGBggASgB";
		buffer[17] = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			AttackDamagePropertyReflection.Descriptor,
			SkillUsePropertyReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleAvatarServantInfo), BattleAvatarServantInfo.Parser, new string[24]
			{
				"AvatarId", "FIFHKNHEIBD", "TotalTurns", "NFEHGEPLPAJ", "SkillTimes", "TotalDamage", "TotalBreakDamage", "AttackTypeDamage", "AttackTypeBreakDamage", "AttackTypeMaxDamage",
				"TotalDamageTaken", "TotalHeal", "TotalHpRecover", "TotalShield", "TotalShieldTaken", "TotalShieldDamage", "BreakTimes", "CEHLLNCEMDN", "HOOFEMEKKOB", "DOAPBOLJOGF",
				"FJLIHMDENML", "EntityId", "ANMBAIFOBJP", "OGDGEKFJAFO"
			}, null, null, null, null)
		}));
	}
}
