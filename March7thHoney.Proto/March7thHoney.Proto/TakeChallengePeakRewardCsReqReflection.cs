using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeChallengePeakRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeChallengePeakRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJUYWtlQ2hhbGxlbmdlUGVha1Jld2FyZENzUmVxLnByb3RvImcKHFRha2VD" + "aGFsbGVuZ2VQZWFrUmV3YXJkQ3NSZXESFQoNcGVha19ncm91cF9pZBgEIAEo" + "DRIdChVub3JtYWxfcmV3YXJkX2lkX2xpc3QYBiADKA0SEQoJcmV3YXJkX2lk" + "GAkgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeChallengePeakRewardCsReq), TakeChallengePeakRewardCsReq.Parser, new string[3] { "PeakGroupId", "NormalRewardIdList", "RewardId" }, null, null, null, null)
		}));
	}
}
