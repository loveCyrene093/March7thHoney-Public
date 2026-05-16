using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPreAvatarGrowthInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPreAvatarGrowthInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRQcmVBdmF0YXJHcm93dGhJbmZvQ3NSZXEucHJvdG8iHQobR2V0UHJl" + "QXZhdGFyR3Jvd3RoSW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPreAvatarGrowthInfoCsReq), GetPreAvatarGrowthInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
