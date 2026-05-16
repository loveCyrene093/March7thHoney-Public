using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVUYWtlUmV3YXJkU2NSc3AucHJvdG8aDkl0ZW1MaXN0LnByb3RvIj0KD1Rh" + "a2VSZXdhcmRTY1JzcBIPCgdyZXRjb2RlGAggASgNEhkKBnJld2FyZBgNIAEo" + "CzIJLkl0ZW1MaXN0QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeRewardScRsp), TakeRewardScRsp.Parser, new string[2] { "Retcode", "Reward" }, null, null, null, null)
		}));
	}
}
