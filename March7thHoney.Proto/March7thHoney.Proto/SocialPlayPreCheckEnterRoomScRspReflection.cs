using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SocialPlayPreCheckEnterRoomScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SocialPlayPreCheckEnterRoomScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZTb2NpYWxQbGF5UHJlQ2hlY2tFbnRlclJvb21TY1JzcC5wcm90byJICiBT" + "b2NpYWxQbGF5UHJlQ2hlY2tFbnRlclJvb21TY1JzcBIPCgdyZXRjb2RlGAIg" + "ASgNEhMKC0RITEdDRUdPTklCGAYgASgDQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SocialPlayPreCheckEnterRoomScRsp), SocialPlayPreCheckEnterRoomScRsp.Parser, new string[2] { "Retcode", "DHLGCEGONIB" }, null, null, null, null)
		}));
	}
}
