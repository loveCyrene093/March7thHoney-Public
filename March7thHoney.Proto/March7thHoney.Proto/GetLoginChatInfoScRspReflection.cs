using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLoginChatInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLoginChatInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRMb2dpbkNoYXRJbmZvU2NSc3AucHJvdG8iQQoVR2V0TG9naW5DaGF0" + "SW5mb1NjUnNwEhcKD2NvbnRhY3RfaWRfbGlzdBgNIAMoDRIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLoginChatInfoScRsp), GetLoginChatInfoScRsp.Parser, new string[2] { "ContactIdList", "Retcode" }, null, null, null, null)
		}));
	}
}
