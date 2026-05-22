using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideTakeChallengeRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideTakeChallengeRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipBZXRoZXJEaXZpZGVUYWtlQ2hhbGxlbmdlUmV3YXJkQ3NSZXEucHJvdG8i" + "PAokQWV0aGVyRGl2aWRlVGFrZUNoYWxsZW5nZVJld2FyZENzUmVxEhQKDGNo" + "YWxsZW5nZV9pZBgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideTakeChallengeRewardCsReq), AetherDivideTakeChallengeRewardCsReq.Parser, new string[1] { "ChallengeId" }, null, null, null, null)
		}));
	}
}
