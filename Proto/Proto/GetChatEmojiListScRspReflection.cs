using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChatEmojiListScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChatEmojiListScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRDaGF0RW1vamlMaXN0U2NSc3AucHJvdG8iQQoVR2V0Q2hhdEVtb2pp" + "TGlzdFNjUnNwEhcKD2NoYXRfZW1vamlfbGlzdBgHIAMoDRIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChatEmojiListScRsp), GetChatEmojiListScRsp.Parser, new string[2] { "ChatEmojiList", "Retcode" }, null, null, null, null)
		}));
	}
}
