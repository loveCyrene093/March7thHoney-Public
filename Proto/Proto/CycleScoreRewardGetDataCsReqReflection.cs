using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CycleScoreRewardGetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CycleScoreRewardGetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJDeWNsZVNjb3JlUmV3YXJkR2V0RGF0YUNzUmVxLnByb3RvIh4KHEN5Y2xl" + "U2NvcmVSZXdhcmRHZXREYXRhQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CycleScoreRewardGetDataCsReq), CycleScoreRewardGetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
