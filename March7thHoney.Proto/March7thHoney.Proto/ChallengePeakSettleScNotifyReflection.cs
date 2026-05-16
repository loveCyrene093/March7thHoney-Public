using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakSettleScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakSettleScNotifyReflection()
	{
		InlineArray10<string> buffer = default(InlineArray10<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 0) = "CiFDaGFsbGVuZ2VQZWFrU2V0dGxlU2NOb3RpZnkucHJvdG8aHkNoYWxsZW5n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 1) = "ZVBlYWtSZXdhcmRHcm91cC5wcm90byLJAgobQ2hhbGxlbmdlUGVha1NldHRs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 2) = "ZVNjTm90aWZ5EhwKFGhhcmRfbW9kZV9oYXNfcGFzc2VkGAIgASgIEhsKE2lz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 3) = "X3VubG9ja19lYXN5X2Jvc3MYAyABKAgSHAoUZmluaXNoZWRfdGFyZ2V0X2xp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 4) = "c3QYBSADKA0SDwoHcGVha19pZBgGIAEoDRIRCgl0dXJuX2xlZnQYByABKA0S";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 5) = "HQoVaXNfYm9zc190YXJnZXRfYmV0dGVyGAggASgIEhMKC2N5Y2xlc191c2Vk";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 6) = "GAogASgNEhcKD2lzX3dhaXRfY29uZmlybRgLIAEoCBIOCgZpc193aW4YDSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 7) = "KAgSOQoWcGVha19yZXdhcmRfZ3JvdXBfbGlzdBgOIAMoCzIZLkNoYWxsZW5n";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 8) = "ZVBlYWtSZXdhcmRHcm91cBIVCg1pc19maXJzdF9wYXNzGA8gASgIQhaqAhNN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray10<string>, string>(ref buffer, 9) = "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray10<string>, string>(in buffer, 10))), new FileDescriptor[1] { ChallengePeakRewardGroupReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakSettleScNotify), ChallengePeakSettleScNotify.Parser, new string[11]
			{
				"HardModeHasPassed", "IsUnlockEasyBoss", "FinishedTargetList", "PeakId", "TurnLeft", "IsBossTargetBetter", "CyclesUsed", "IsWaitConfirm", "IsWin", "PeakRewardGroupList",
				"IsFirstPass"
			}, null, null, null, null)
		}));
	}
}
