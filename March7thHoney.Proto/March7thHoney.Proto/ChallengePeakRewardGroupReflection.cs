using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengePeakRewardGroupReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengePeakRewardGroupReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGFsbGVuZ2VQZWFrUmV3YXJkR3JvdXAucHJvdG8aDkl0ZW1MaXN0LnBy" + "b3RvIkgKGENoYWxsZW5nZVBlYWtSZXdhcmRHcm91cBIZCgZyZXdhcmQYASAB" + "KAsyCS5JdGVtTGlzdBIRCglyZXdhcmRfaWQYByABKA1CFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengePeakRewardGroup), ChallengePeakRewardGroup.Parser, new string[2] { "Reward", "RewardId" }, null, null, null, null)
		}));
	}
}
