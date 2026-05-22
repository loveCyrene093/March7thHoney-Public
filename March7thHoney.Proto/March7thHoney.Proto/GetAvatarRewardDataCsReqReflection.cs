using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAvatarRewardDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAvatarRewardDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRBdmF0YXJSZXdhcmREYXRhQ3NSZXEucHJvdG8iGgoYR2V0QXZhdGFy" + "UmV3YXJkRGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAvatarRewardDataCsReq), GetAvatarRewardDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
