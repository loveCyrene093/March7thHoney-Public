using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightTakeWeeklyRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightTakeWeeklyRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHcmlkRmlnaHRUYWtlV2Vla2x5UmV3YXJkQ3NSZXEucHJvdG8iRAoeR3Jp" + "ZEZpZ2h0VGFrZVdlZWtseVJld2FyZENzUmVxEiIKGmdyaWRfZmlnaHRfc2Nv" + "cmVfcmFua19saXN0GAQgAygNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightTakeWeeklyRewardCsReq), GridFightTakeWeeklyRewardCsReq.Parser, new string[1] { "GridFightScoreRankList" }, null, null, null, null)
		}));
	}
}
