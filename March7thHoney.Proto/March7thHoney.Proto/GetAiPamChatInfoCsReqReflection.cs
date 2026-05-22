using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAiPamChatInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAiPamChatInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRBaVBhbUNoYXRJbmZvQ3NSZXEucHJvdG8iFwoVR2V0QWlQYW1DaGF0" + "SW5mb0NzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAiPamChatInfoCsReq), GetAiPamChatInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
