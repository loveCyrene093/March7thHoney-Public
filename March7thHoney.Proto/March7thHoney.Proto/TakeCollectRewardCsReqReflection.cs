using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeCollectRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeCollectRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxUYWtlQ29sbGVjdFJld2FyZENzUmVxLnByb3RvIikKFlRha2VDb2xsZWN0" + "UmV3YXJkQ3NSZXESDwoHaXRlbV9pZBgNIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeCollectRewardCsReq), TakeCollectRewardCsReq.Parser, new string[1] { "ItemId" }, null, null, null, null)
		}));
	}
}
