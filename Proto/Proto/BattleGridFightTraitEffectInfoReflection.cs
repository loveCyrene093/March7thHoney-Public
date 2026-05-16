using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleGridFightTraitEffectInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleGridFightTraitEffectInfoReflection()
	{
		InlineArray12<string> buffer = default(InlineArray12<string>);
		buffer[0] = "CiRCYXR0bGVHcmlkRmlnaHRUcmFpdEVmZmVjdEluZm8ucHJvdG8aJkJhdHRs";
		buffer[1] = "ZUdyaWRGaWdodFRyYWl0Q29yZVJvbGVJbmZvLnByb3RvGidCYXR0bGVHcmlk";
		buffer[2] = "RmlnbnRBdmF0YXJDb3JlUm9sZUluZm8ucHJvdG8aEURGSkdQT0RBS0FNLnBy";
		buffer[3] = "b3RvGiNHcmlkRmlnaHRUcmFpdEVmZmVjdExldmVsSW5mby5wcm90byKoAgoe";
		buffer[4] = "QmF0dGxlR3JpZEZpZ2h0VHJhaXRFZmZlY3RJbmZvEhEKCWVmZmVjdF9pZBgB";
		buffer[5] = "IAEoDRI8Cg90cmFpdF9jb3JlX3JvbGUYZSABKAsyIS5CYXR0bGVHcmlkRmln";
		buffer[6] = "aHRUcmFpdENvcmVSb2xlSW5mb0gAEj4KEGF2YXRhcl9jb3JlX2luZm8YZiAB";
		buffer[7] = "KAsyIi5CYXR0bGVHcmlkRmlnbnRBdmF0YXJDb3JlUm9sZUluZm9IABJBChd0";
		buffer[8] = "cmFpdF9lZmZlY3RfbGV2ZWxfaW5mbxhnIAEoCzIeLkdyaWRGaWdodFRyYWl0";
		buffer[9] = "RWZmZWN0TGV2ZWxJbmZvSAASIwoLSEFJTkpLTExMS0YYaCABKAsyDC5ERkpH";
		buffer[10] = "UE9EQUtBTUgAQg0KC0hEQUNDSUVJSkZPQhaqAhNNYXJjaDd0aEhvbmV5LlBy";
		buffer[11] = "b3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[4]
		{
			BattleGridFightTraitCoreRoleInfoReflection.Descriptor,
			BattleGridFigntAvatarCoreRoleInfoReflection.Descriptor,
			DFJGPODAKAMReflection.Descriptor,
			GridFightTraitEffectLevelInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleGridFightTraitEffectInfo), BattleGridFightTraitEffectInfo.Parser, new string[5] { "EffectId", "TraitCoreRole", "AvatarCoreInfo", "TraitEffectLevelInfo", "HAINJKLLLKF" }, new string[1] { "HDACCIEIJFO" }, null, null, null)
		}));
	}
}
