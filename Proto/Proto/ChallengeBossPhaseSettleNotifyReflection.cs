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
		buffer[0] = "CiRDaGFsbGVuZ2VCb3NzUGhhc2VTZXR0bGVOb3RpZnkucHJvdG8aEkJhdHRs";
		buffer[1] = "ZVRhcmdldC5wcm90byL4AQoeQ2hhbGxlbmdlQm9zc1BoYXNlU2V0dGxlTm90";
		buffer[2] = "aWZ5EhEKCWlzX3Jld2FyZBgBIAEoCBIMCgRzdGFyGAMgASgNEhYKDmlzX3Nl";
		buffer[3] = "Y29uZF9oYWxmGAQgASgIEg0KBXBoYXNlGAYgASgNEhQKDGNoYWxsZW5nZV9p";
		buffer[4] = "ZBgHIAEoDRIRCglwYWdlX3R5cGUYCCABKA0SEQoJc2NvcmVfdHdvGAogASgN";
		buffer[5] = "EikKEmJhdHRsZV90YXJnZXRfbGlzdBgLIAMoCzINLkJhdHRsZVRhcmdldBIO";
		buffer[6] = "CgZpc193aW4YDSABKAgSFwoPY2hhbGxlbmdlX3Njb3JlGA8gASgNQhaqAhNN";
		buffer[7] = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { BattleTargetReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeBossPhaseSettleNotify), ChallengeBossPhaseSettleNotify.Parser, new string[10] { "IsReward", "Star", "IsSecondHalf", "Phase", "ChallengeId", "PageType", "ScoreTwo", "BattleTargetList", "IsWin", "ChallengeScore" }, null, null, null, null)
		}));
	}
}
