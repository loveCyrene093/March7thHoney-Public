using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSecretKeyInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSecretKeyInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRTZWNyZXRLZXlJbmZvQ3NSZXEucHJvdG8iLAoVR2V0U2VjcmV0S2V5" + "SW5mb0NzUmVxEhMKC01FTkhDQ05LQURCGA4gASgMQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSecretKeyInfoCsReq), GetSecretKeyInfoCsReq.Parser, new string[1] { "MENHCCNKADB" }, null, null, null, null)
		}));
	}
}
