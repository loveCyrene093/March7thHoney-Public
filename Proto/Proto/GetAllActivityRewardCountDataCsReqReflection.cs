using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAllActivityRewardCountDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAllActivityRewardCountDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CihHZXRBbGxBY3Rpdml0eVJld2FyZENvdW50RGF0YUNzUmVxLnByb3RvIiQK" + "IkdldEFsbEFjdGl2aXR5UmV3YXJkQ291bnREYXRhQ3NSZXFCFqoCE01hcmNo" + "N3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAllActivityRewardCountDataCsReq), GetAllActivityRewardCountDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
