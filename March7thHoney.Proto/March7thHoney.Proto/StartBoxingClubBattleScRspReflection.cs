using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartBoxingClubBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartBoxingClubBattleScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiBTdGFydEJveGluZ0NsdWJCYXR0bGVTY1JzcC5wcm90bxoVU2NlbmVCYXR0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bGVJbmZvLnByb3RvImoKGlN0YXJ0Qm94aW5nQ2x1YkJhdHRsZVNjUnNwEiUK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "C2JhdHRsZV9pbmZvGAEgASgLMhAuU2NlbmVCYXR0bGVJbmZvEhQKDGNoYWxs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "ZW5nZV9pZBgCIAEoDRIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0aEhv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "bmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartBoxingClubBattleScRsp), StartBoxingClubBattleScRsp.Parser, new string[3] { "BattleInfo", "ChallengeId", "Retcode" }, null, null, null, null)
		}));
	}
}
