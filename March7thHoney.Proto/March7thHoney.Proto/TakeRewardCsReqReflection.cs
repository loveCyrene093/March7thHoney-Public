using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVUYWtlUmV3YXJkQ3NSZXEucHJvdG8iEQoPVGFrZVJld2FyZENzUmVxQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRewardCsReq), TakeRewardCsReq.Parser, null, null, null, null, null)
		}));
	}
}
