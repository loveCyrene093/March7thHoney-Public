using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeChallengeRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeChallengeRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5UYWtlQ2hhbGxlbmdlUmV3YXJkQ3NSZXEucHJvdG8iLAoYVGFrZUNoYWxs" + "ZW5nZVJld2FyZENzUmVxEhAKCGdyb3VwX2lkGAcgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengeRewardCsReq), TakeChallengeRewardCsReq.Parser, new string[1] { "GroupId" }, null, null, null, null)
		}));
	}
}
