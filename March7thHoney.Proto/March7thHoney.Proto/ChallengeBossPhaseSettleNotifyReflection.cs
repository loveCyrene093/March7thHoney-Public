using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeBossPhaseSettleNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeBossPhaseSettleNotifyReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "CiRDaGFsbGVuZ2VCb3NzUGhhc2VTZXR0bGVOb3RpZnkucHJvdG8aEkJhdHRs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "ZVRhcmdldC5wcm90byL4AQoeQ2hhbGxlbmdlQm9zc1BoYXNlU2V0dGxlTm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "aWZ5EhEKCWlzX3Jld2FyZBgBIAEoCBIMCgRzdGFyGAMgASgNEhYKDmlzX3Nl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "Y29uZF9oYWxmGAQgASgIEg0KBXBoYXNlGAYgASgNEhQKDGNoYWxsZW5nZV9p";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "ZBgHIAEoDRIRCglwYWdlX3R5cGUYCCABKA0SEQoJc2NvcmVfdHdvGAogASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "EikKEmJhdHRsZV90YXJnZXRfbGlzdBgLIAMoCzINLkJhdHRsZVRhcmdldBIO";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "CgZpc193aW4YDSABKAgSFwoPY2hhbGxlbmdlX3Njb3JlGA8gASgNQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[1] { BattleTargetReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossPhaseSettleNotify), ChallengeBossPhaseSettleNotify.Parser, new string[10] { "IsReward", "Star", "IsSecondHalf", "Phase", "ChallengeId", "PageType", "ScoreTwo", "BattleTargetList", "IsWin", "ChallengeScore" }, null, null, null, null)
		}));
	}
}
