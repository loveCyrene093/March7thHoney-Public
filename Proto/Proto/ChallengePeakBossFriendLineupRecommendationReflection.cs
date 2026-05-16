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
		buffer[0] = "CjFDaGFsbGVuZ2VQZWFrQm9zc0ZyaWVuZExpbmV1cFJlY29tbWVuZGF0aW9u";
		buffer[1] = "LnByb3RvGhFQS0pHR0FQTE9OQy5wcm90byKzAQorQ2hhbGxlbmdlUGVha0Jv";
		buffer[2] = "c3NGcmllbmRMaW5ldXBSZWNvbW1lbmRhdGlvbhIhCgthdmF0YXJfbGlzdBgB";
		buffer[3] = "IAMoCzIMLlBLSkdHQVBMT05DEhwKFGZpbmlzaGVkX3RhcmdldF9saXN0GAIg";
		buffer[4] = "AygNEhQKDGlzX2hhcmRfbW9kZRgIIAEoCBIPCgdidWZmX2lkGAkgASgNEhwK";
		buffer[5] = "FGhhcmRfbW9kZV9oYXNfcGFzc2VkGA4gASgIQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[6] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { PKJGGAPLONCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakBossFriendLineupRecommendation), ChallengePeakBossFriendLineupRecommendation.Parser, new string[5] { "AvatarList", "FinishedTargetList", "IsHardMode", "BuffId", "HardModeHasPassed" }, null, null, null, null)
		}));
	}
}
