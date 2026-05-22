using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueScoreRewardInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueScoreRewardInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRSb2d1ZVNjb3JlUmV3YXJkSW5mb0NzUmVxLnByb3RvIh4KHEdldFJv" + "Z3VlU2NvcmVSZXdhcmRJbmZvQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueScoreRewardInfoCsReq), GetRogueScoreRewardInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
