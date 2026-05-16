using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideBattleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideBattleInfoReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 0) = "ChxBZXRoZXJEaXZpZGVCYXR0bGVJbmZvLnByb3RvGhZBZXRoZXJBdmF0YXJJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 1) = "bmZvLnByb3RvGhBCYXR0bGVCdWZmLnByb3RvGhZTY2VuZU1vbnN0ZXJXYXZl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 2) = "LnByb3RvIuoBChZBZXRoZXJEaXZpZGVCYXR0bGVJbmZvEhAKCHN0YWdlX2lk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 3) = "GAEgASgNEh4KCWJ1ZmZfbGlzdBgCIAMoCzILLkJhdHRsZUJ1ZmYSLQoSYmF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 4) = "dGxlX2F2YXRhcl9saXN0GAUgAygLMhEuQWV0aGVyQXZhdGFySW5mbxITCgtF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 5) = "T0RITU9CT0VORxgGIAEoCBIZChFsb2dpY19yYW5kb21fc2VlZBgHIAEoDRIs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 6) = "ChFtb25zdGVyX3dhdmVfbGlzdBgLIAMoCzIRLlNjZW5lTW9uc3RlcldhdmUS";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 7) = "EQoJYmF0dGxlX2lkGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray9<string>, string>(ref buffer, 8) = "cm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray9<string>, string>(in buffer, 9))), new FileDescriptor[3]
		{
			AetherAvatarInfoReflection.Descriptor,
			BattleBuffReflection.Descriptor,
			SceneMonsterWaveReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideBattleInfo), AetherDivideBattleInfo.Parser, new string[7] { "StageId", "BuffList", "BattleAvatarList", "EODHMOBOENG", "LogicRandomSeed", "MonsterWaveList", "BattleId" }, null, null, null, null)
		}));
	}
}
