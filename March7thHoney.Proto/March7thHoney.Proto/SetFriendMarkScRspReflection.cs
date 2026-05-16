using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetFriendMarkScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetFriendMarkScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRGcmllbmRNYXJrU2NSc3AucHJvdG8iRwoSU2V0RnJpZW5kTWFya1Nj" + "UnNwEgsKA3VpZBgEIAEoDRIPCgdyZXRjb2RlGAUgASgNEhMKC0tCTktOQUhH" + "UEhHGAggASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetFriendMarkScRsp), SetFriendMarkScRsp.Parser, new string[3] { "Uid", "Retcode", "KBNKNAHGPHG" }, null, null, null, null)
		}));
	}
}
