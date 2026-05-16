using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeChallengeRaidRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeChallengeRaidRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlQ2hhbGxlbmdlUmFpZFJld2FyZENzUmVxLnByb3RvIjMKHFRha2VD" + "aGFsbGVuZ2VSYWlkUmV3YXJkQ3NSZXESEwoLS0lCTkxORlBGSUMYCyABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengeRaidRewardCsReq), TakeChallengeRaidRewardCsReq.Parser, new string[1] { "KIBNLNFPFIC" }, null, null, null, null)
		}));
	}
}
