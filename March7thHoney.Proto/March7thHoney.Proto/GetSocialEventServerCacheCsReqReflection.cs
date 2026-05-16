using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSocialEventServerCacheCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSocialEventServerCacheCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHZXRTb2NpYWxFdmVudFNlcnZlckNhY2hlQ3NSZXEucHJvdG8iIAoeR2V0" + "U29jaWFsRXZlbnRTZXJ2ZXJDYWNoZUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSocialEventServerCacheCsReq), GetSocialEventServerCacheCsReq.Parser, null, null, null, null, null)
		}));
	}
}
