using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeCollectRewardRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeCollectRewardRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpUYWtlQ29sbGVjdFJld2FyZFJzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8i" + "UwoUVGFrZUNvbGxlY3RSZXdhcmRSc3ASGQoGcmV3YXJkGAEgASgLMgkuSXRl" + "bUxpc3QSDwoHaXRlbV9pZBgEIAEoDRIPCgdyZXRjb2RlGAggASgNQhaqAhNN" + "YXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeCollectRewardRsp), TakeCollectRewardRsp.Parser, new string[3] { "Reward", "ItemId", "Retcode" }, null, null, null, null)
		}));
	}
}
