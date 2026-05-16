using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMonopolyMbtiReportRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMonopolyMbtiReportRewardScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZHZXRNb25vcG9seU1idGlSZXBvcnRSZXdhcmRTY1JzcC5wcm90bxoOSXRl" + "bUxpc3QucHJvdG8iUwogR2V0TW9ub3BvbHlNYnRpUmVwb3J0UmV3YXJkU2NS" + "c3ASHgoLcmV3YXJkX2xpc3QYDSABKAsyCS5JdGVtTGlzdBIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMonopolyMbtiReportRewardScRsp), GetMonopolyMbtiReportRewardScRsp.Parser, new string[2] { "RewardList", "Retcode" }, null, null, null, null)
		}));
	}
}
