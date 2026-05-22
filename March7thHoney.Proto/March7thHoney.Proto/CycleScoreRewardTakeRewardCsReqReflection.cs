using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CycleScoreRewardTakeRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CycleScoreRewardTakeRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVDeWNsZVNjb3JlUmV3YXJkVGFrZVJld2FyZENzUmVxLnByb3RvIkUKH0N5" + "Y2xlU2NvcmVSZXdhcmRUYWtlUmV3YXJkQ3NSZXESIgoaZ3JpZF9maWdodF9z" + "Y29yZV9yYW5rX2xpc3QYDCADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CycleScoreRewardTakeRewardCsReq), CycleScoreRewardTakeRewardCsReq.Parser, new string[1] { "GridFightScoreRankList" }, null, null, null, null)
		}));
	}
}
