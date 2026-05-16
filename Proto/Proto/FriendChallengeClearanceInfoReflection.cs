using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FriendChallengeClearanceInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FriendChallengeClearanceInfoReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "CiJGcmllbmRDaGFsbGVuZ2VDbGVhcmFuY2VJbmZvLnByb3RvGh1DaGFsbGVu";
		buffer[1] = "Z2VCb3NzU3RhdGlzdGljcy5wcm90bxoZQ2hhbGxlbmdlU3RhdGlzdGljcy5w";
		buffer[2] = "cm90bxoeQ2hhbGxlbmdlU3RvcnlTdGF0aXN0aWNzLnByb3RvIvQBChxGcmll";
		buffer[3] = "bmRDaGFsbGVuZ2VDbGVhcmFuY2VJbmZvEhAKCGdyb3VwX2lkGAMgASgNEhMK";
		buffer[4] = "C0hDSENPQVBKTE1HGAQgASgNEjMKDmNoYWxsZW5nZV9ib3NzGJ8IIAEoCzIY";
		buffer[5] = "LkNoYWxsZW5nZUJvc3NTdGF0aXN0aWNzSAASNQoPY2hhbGxlbmdlX3N0b3J5";
		buffer[6] = "GOkLIAEoCzIZLkNoYWxsZW5nZVN0b3J5U3RhdGlzdGljc0gAEjIKEWNoYWxs";
		buffer[7] = "ZW5nZV9kZWZhdWx0GIkPIAEoCzIULkNoYWxsZW5nZVN0YXRpc3RpY3NIAEIN";
		buffer[8] = "CgtISUFDTkhOTENHTEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ChallengeBossStatisticsReflection.Descriptor,
			ChallengeStatisticsReflection.Descriptor,
			ChallengeStoryStatisticsReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FriendChallengeClearanceInfo), FriendChallengeClearanceInfo.Parser, new string[5] { "GroupId", "HCHCOAPJLMG", "ChallengeBoss", "ChallengeStory", "ChallengeDefault" }, new string[1] { "HIACNHNLCGL" }, null, null, null)
		}));
	}
}
