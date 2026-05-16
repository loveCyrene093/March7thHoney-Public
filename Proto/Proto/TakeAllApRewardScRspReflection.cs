using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeAllApRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeAllApRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpUYWtlQWxsQXBSZXdhcmRTY1JzcC5wcm90bxoOSXRlbUxpc3QucHJvdG8i" + "YgoUVGFrZUFsbEFwUmV3YXJkU2NSc3ASGQoGcmV3YXJkGAEgASgLMgkuSXRl" + "bUxpc3QSHgoWdGFrZV9yZXdhcmRfbGV2ZWxfbGlzdBgCIAMoDRIPCgdyZXRj" + "b2RlGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeAllApRewardScRsp), TakeAllApRewardScRsp.Parser, new string[3] { "Reward", "TakeRewardLevelList", "Retcode" }, null, null, null, null)
		}));
	}
}
