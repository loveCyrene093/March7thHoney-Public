using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLoginChatInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLoginChatInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRMb2dpbkNoYXRJbmZvQ3NSZXEucHJvdG8iFwoVR2V0TG9naW5DaGF0" + "SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLoginChatInfoCsReq), GetLoginChatInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
