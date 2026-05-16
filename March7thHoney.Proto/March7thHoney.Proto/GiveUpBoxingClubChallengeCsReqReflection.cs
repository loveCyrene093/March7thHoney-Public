using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GiveUpBoxingClubChallengeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GiveUpBoxingClubChallengeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHaXZlVXBCb3hpbmdDbHViQ2hhbGxlbmdlQ3NSZXEucHJvdG8iSwoeR2l2" + "ZVVwQm94aW5nQ2x1YkNoYWxsZW5nZUNzUmVxEhQKDGNoYWxsZW5nZV9pZBgB" + "IAEoDRITCgtQQU1ETEhPQ01DQxgCIAEoCEIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GiveUpBoxingClubChallengeCsReq), GiveUpBoxingClubChallengeCsReq.Parser, new string[2] { "ChallengeId", "PAMDLHOCMCC" }, null, null, null, null)
		}));
	}
}
