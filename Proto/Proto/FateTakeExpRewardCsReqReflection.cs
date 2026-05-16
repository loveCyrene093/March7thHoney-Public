using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateTakeExpRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateTakeExpRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxGYXRlVGFrZUV4cFJld2FyZENzUmVxLnByb3RvIhgKFkZhdGVUYWtlRXhw" + "UmV3YXJkQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateTakeExpRewardCsReq), FateTakeExpRewardCsReq.Parser, null, null, null, null, null)
		}));
	}
}
