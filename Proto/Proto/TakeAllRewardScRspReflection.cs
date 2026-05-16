using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeAllRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeAllRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhUYWtlQWxsUmV3YXJkU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3RvIkAK" + "ElRha2VBbGxSZXdhcmRTY1JzcBIPCgdyZXRjb2RlGAsgASgNEhkKBnJld2Fy" + "ZBgMIAEoCzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeAllRewardScRsp), TakeAllRewardScRsp.Parser, new string[2] { "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
