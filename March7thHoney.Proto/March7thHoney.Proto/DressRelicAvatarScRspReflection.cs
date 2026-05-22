using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DressRelicAvatarScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DressRelicAvatarScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtEcmVzc1JlbGljQXZhdGFyU2NSc3AucHJvdG8iOwoVRHJlc3NSZWxpY0F2" + "YXRhclNjUnNwEg8KB3JldGNvZGUYBSABKA0SEQoJYXZhdGFyX2lkGA4gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DressRelicAvatarScRsp), DressRelicAvatarScRsp.Parser, new string[2] { "Retcode", "AvatarId" }, null, null, null, null)
		}));
	}
}
