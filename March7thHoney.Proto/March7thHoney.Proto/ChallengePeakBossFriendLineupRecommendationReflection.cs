using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakBossFriendLineupRecommendationReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakBossFriendLineupRecommendationReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 0) = "CjFDaGFsbGVuZ2VQZWFrQm9zc0ZyaWVuZExpbmV1cFJlY29tbWVuZGF0aW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 1) = "LnByb3RvGhFQS0pHR0FQTE9OQy5wcm90byKzAQorQ2hhbGxlbmdlUGVha0Jv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 2) = "c3NGcmllbmRMaW5ldXBSZWNvbW1lbmRhdGlvbhIhCgthdmF0YXJfbGlzdBgB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 3) = "IAMoCzIMLlBLSkdHQVBMT05DEhwKFGZpbmlzaGVkX3RhcmdldF9saXN0GAIg";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 4) = "AygNEhQKDGlzX2hhcmRfbW9kZRgIIAEoCBIPCgdidWZmX2lkGAkgASgNEhwK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 5) = "FGhhcmRfbW9kZV9oYXNfcGFzc2VkGA4gASgIQhaqAhNNYXJjaDd0aEhvbmV5";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray7<string>, string>(ref buffer, 6) = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray7<string>, string>(in buffer, 7))), new FileDescriptor[1] { PKJGGAPLONCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakBossFriendLineupRecommendation), ChallengePeakBossFriendLineupRecommendation.Parser, new string[5] { "AvatarList", "FinishedTargetList", "IsHardMode", "BuffId", "HardModeHasPassed" }, null, null, null, null)
		}));
	}
}
