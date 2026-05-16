using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneBattleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneBattleInfoReflection()
	{
		_003C_003Ey__InlineArray24<string> buffer = default(_003C_003Ey__InlineArray24<string>);
		buffer[0] = "ChVTY2VuZUJhdHRsZUluZm8ucHJvdG8aEkJhdHRsZUF2YXRhci5wcm90bxoQ";
		buffer[1] = "QmF0dGxlQnVmZi5wcm90bxobQmF0dGxlRXZlbnRCYXR0bGVJbmZvLnByb3Rv";
		buffer[2] = "GiZCYXR0bGVHcmlkRmlnaHRTcGVjaWFsQmF0dGxlSW5mby5wcm90bxoaQmF0";
		buffer[3] = "dGxlUm9ndWVNYWdpY0luZm8ucHJvdG8aFkJhdHRsZVRhcmdldExpc3QucHJv";
		buffer[4] = "dG8aEUNBS0dPR01FSk9GLnByb3RvGhFLQ0dQTU5OS0lLTi5wcm90bxoRTUxE";
		buffer[5] = "RURDQ09IQkYucHJvdG8aEU9HRU9NREpJQUdJLnByb3RvGhZTY2VuZU1vbnN0";
		buffer[6] = "ZXJXYXZlLnByb3RvIukFCg9TY2VuZUJhdHRsZUluZm8SEQoJYmF0dGxlX2lk";
		buffer[7] = "GAEgASgNEhAKCHN0YWdlX2lkGAIgASgNEhMKC0VPREhNT0JPRU5HGAMgASgI";
		buffer[8] = "EiwKEW1vbnN0ZXJfd2F2ZV9saXN0GAQgAygLMhEuU2NlbmVNb25zdGVyV2F2";
		buffer[9] = "ZRITCgt3b3JsZF9sZXZlbBgGIAEoDRIZChFsb2dpY19yYW5kb21fc2VlZBgI";
		buffer[10] = "IAEoDRIpChJiYXR0bGVfYXZhdGFyX2xpc3QYCSADKAsyDS5CYXR0bGVBdmF0";
		buffer[11] = "YXISHgoJYnVmZl9saXN0GA0gAygLMgsuQmF0dGxlQnVmZhIUCgxyb3VuZHNf";
		buffer[12] = "bGltaXQYDiABKA0SGwoTbW9uc3Rlcl93YXZlX2xlbmd0aBgPIAEoDRItCgxi";
		buffer[13] = "YXR0bGVfZXZlbnQY6gEgAygLMhYuQmF0dGxlRXZlbnRCYXR0bGVJbmZvEiIK";
		buffer[14] = "C0lBSkRDSklBSEZQGPwDIAEoCzIMLkNBS0dPR01FSk9GEjcKF2JhdHRsZV9y";
		buffer[15] = "b2d1ZV9tYWdpY19pbmZvGK4EIAEoCzIVLkJhdHRsZVJvZ3VlTWFnaWNJbmZv";
		buffer[16] = "EkMKEmJhdHRsZV90YXJnZXRfaW5mbxj5BSADKAsyJi5TY2VuZUJhdHRsZUlu";
		buffer[17] = "Zm8uQmF0dGxlVGFyZ2V0SW5mb0VudHJ5EiIKC0dEQUdISUpBRE9EGMYGIAEo";
		buffer[18] = "CzIMLktDR1BNTk5LSUtOEiIKC09CT0ZPQ1BDQlBLGOcKIAEoCzIMLk1MREVE";
		buffer[19] = "Q0NPSEJGEjcKC0ZNQ0pQUElMUExMGPYMIAEoCzIhLkJhdHRsZUdyaWRGaWdo";
		buffer[20] = "dFNwZWNpYWxCYXR0bGVJbmZvEiIKC0FGQ01PT0ZHQlBLGKcOIAEoCzIMLk9H";
		buffer[21] = "RU9NREpJQUdJGkoKFUJhdHRsZVRhcmdldEluZm9FbnRyeRILCgNrZXkYASAB";
		buffer[22] = "KA0SIAoFdmFsdWUYAiABKAsyES5CYXR0bGVUYXJnZXRMaXN0OgI4AUIWqgIT";
		buffer[23] = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[11]
		{
			BattleAvatarReflection.Descriptor,
			BattleBuffReflection.Descriptor,
			BattleEventBattleInfoReflection.Descriptor,
			BattleGridFightSpecialBattleInfoReflection.Descriptor,
			BattleRogueMagicInfoReflection.Descriptor,
			BattleTargetListReflection.Descriptor,
			CAKGOGMEJOFReflection.Descriptor,
			KCGPMNNKIKNReflection.Descriptor,
			MLDEDCCOHBFReflection.Descriptor,
			OGEOMDJIAGIReflection.Descriptor,
			SceneMonsterWaveReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneBattleInfo), SceneBattleInfo.Parser, new string[18]
			{
				"BattleId", "StageId", "EODHMOBOENG", "MonsterWaveList", "WorldLevel", "LogicRandomSeed", "BattleAvatarList", "BuffList", "RoundsLimit", "MonsterWaveLength",
				"BattleEvent", "IAJDCJIAHFP", "BattleRogueMagicInfo", "BattleTargetInfo", "GDAGHIJADOD", "OBOFOCPCBPK", "FMCJPPILPLL", "AFCMOOFGBPK"
			}, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
