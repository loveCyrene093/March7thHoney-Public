using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChatEmojiListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChatEmojiListCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRDaGF0RW1vamlMaXN0Q3NSZXEucHJvdG8iFwoVR2V0Q2hhdEVtb2pp" + "TGlzdENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChatEmojiListCsReq), GetChatEmojiListCsReq.Parser, null, null, null, null, null)
		}));
	}
}
