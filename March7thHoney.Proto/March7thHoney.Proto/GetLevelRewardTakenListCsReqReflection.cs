using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLevelRewardTakenListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLevelRewardTakenListCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJHZXRMZXZlbFJld2FyZFRha2VuTGlzdENzUmVxLnByb3RvIh4KHEdldExl" + "dmVsUmV3YXJkVGFrZW5MaXN0Q3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLevelRewardTakenListCsReq), GetLevelRewardTakenListCsReq.Parser, null, null, null, null, null)
		}));
	}
}
