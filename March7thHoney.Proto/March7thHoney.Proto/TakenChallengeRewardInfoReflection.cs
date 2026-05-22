using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakenChallengeRewardInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakenChallengeRewardInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5UYWtlbkNoYWxsZW5nZVJld2FyZEluZm8ucHJvdG8aDkl0ZW1MaXN0LnBy" + "b3RvIkkKGFRha2VuQ2hhbGxlbmdlUmV3YXJkSW5mbxISCgpzdGFyX2NvdW50" + "GAYgASgNEhkKBnJld2FyZBgIIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakenChallengeRewardInfo), TakenChallengeRewardInfo.Parser, new string[2] { "StarCount", "Reward" }, null, null, null, null)
		}));
	}
}
