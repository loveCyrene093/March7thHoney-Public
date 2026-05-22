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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 0) = "ChVTY2VuZUJhdHRsZUluZm8ucHJvdG8aEkJhdHRsZUF2YXRhci5wcm90bxoQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 1) = "QmF0dGxlQnVmZi5wcm90bxobQmF0dGxlRXZlbnRCYXR0bGVJbmZvLnByb3Rv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 2) = "GiZCYXR0bGVHcmlkRmlnaHRTcGVjaWFsQmF0dGxlSW5mby5wcm90bxoaQmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 3) = "dGxlUm9ndWVNYWdpY0luZm8ucHJvdG8aFkJhdHRsZVRhcmdldExpc3QucHJv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 4) = "dG8aEUNBS0dPR01FSk9GLnByb3RvGhFLQ0dQTU5OS0lLTi5wcm90bxoRTUxE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 5) = "RURDQ09IQkYucHJvdG8aEU9HRU9NREpJQUdJLnByb3RvGhZTY2VuZU1vbnN0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 6) = "ZXJXYXZlLnByb3RvIukFCg9TY2VuZUJhdHRsZUluZm8SEQoJYmF0dGxlX2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 7) = "GAEgASgNEhAKCHN0YWdlX2lkGAIgASgNEhMKC0VPREhNT0JPRU5HGAMgASgI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 8) = "EiwKEW1vbnN0ZXJfd2F2ZV9saXN0GAQgAygLMhEuU2NlbmVNb25zdGVyV2F2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 9) = "ZRITCgt3b3JsZF9sZXZlbBgGIAEoDRIZChFsb2dpY19yYW5kb21fc2VlZBgI";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 10) = "IAEoDRIpChJiYXR0bGVfYXZhdGFyX2xpc3QYCSADKAsyDS5CYXR0bGVBdmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 11) = "YXISHgoJYnVmZl9saXN0GA0gAygLMgsuQmF0dGxlQnVmZhIUCgxyb3VuZHNf";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 12) = "bGltaXQYDiABKA0SGwoTbW9uc3Rlcl93YXZlX2xlbmd0aBgPIAEoDRItCgxi";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 13) = "YXR0bGVfZXZlbnQY6gEgAygLMhYuQmF0dGxlRXZlbnRCYXR0bGVJbmZvEiIK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 14) = "C0lBSkRDSklBSEZQGPwDIAEoCzIMLkNBS0dPR01FSk9GEjcKF2JhdHRsZV9y";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 15) = "b2d1ZV9tYWdpY19pbmZvGK4EIAEoCzIVLkJhdHRsZVJvZ3VlTWFnaWNJbmZv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 16) = "EkMKEmJhdHRsZV90YXJnZXRfaW5mbxj5BSADKAsyJi5TY2VuZUJhdHRsZUlu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 17) = "Zm8uQmF0dGxlVGFyZ2V0SW5mb0VudHJ5EiIKC0dEQUdISUpBRE9EGMYGIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 18) = "CzIMLktDR1BNTk5LSUtOEiIKC09CT0ZPQ1BDQlBLGOcKIAEoCzIMLk1MREVE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 19) = "Q0NPSEJGEjcKC0ZNQ0pQUElMUExMGPYMIAEoCzIhLkJhdHRsZUdyaWRGaWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 20) = "dFNwZWNpYWxCYXR0bGVJbmZvEiIKC0FGQ01PT0ZHQlBLGKcOIAEoCzIMLk9H";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 21) = "RU9NREpJQUdJGkoKFUJhdHRsZVRhcmdldEluZm9FbnRyeRILCgNrZXkYASAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 22) = "KA0SIAoFdmFsdWUYAiABKAsyES5CYXR0bGVUYXJnZXRMaXN0OgI4AUIWqgIT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray24<string>, string>(ref buffer, 23) = "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray24<string>, string>(in buffer, 24))), new FileDescriptor[11]
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
