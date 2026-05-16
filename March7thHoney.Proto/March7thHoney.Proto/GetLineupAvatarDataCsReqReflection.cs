using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLineupAvatarDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLineupAvatarDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRMaW5ldXBBdmF0YXJEYXRhQ3NSZXEucHJvdG8iGgoYR2V0TGluZXVw" + "QXZhdGFyRGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLineupAvatarDataCsReq), GetLineupAvatarDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
