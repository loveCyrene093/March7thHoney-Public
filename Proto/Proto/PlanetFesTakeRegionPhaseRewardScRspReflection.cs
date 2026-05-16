using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesTakeRegionPhaseRewardScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesTakeRegionPhaseRewardScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CilQbGFuZXRGZXNUYWtlUmVnaW9uUGhhc2VSZXdhcmRTY1JzcC5wcm90bxoO";
		buffer[1] = "SXRlbUxpc3QucHJvdG8iawojUGxhbmV0RmVzVGFrZVJlZ2lvblBoYXNlUmV3";
		buffer[2] = "YXJkU2NSc3ASHgoLcmV3YXJkX2xpc3QYAyABKAsyCS5JdGVtTGlzdBITCgtI";
		buffer[3] = "Sk1HR0xBTkhNTBgHIAEoDRIPCgdyZXRjb2RlGAwgASgNQhaqAhNNYXJjaDd0";
		buffer[4] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesTakeRegionPhaseRewardScRsp), PlanetFesTakeRegionPhaseRewardScRsp.Parser, new string[3] { "RewardList", "HJMGGLANHML", "Retcode" }, null, null, null, null)
		}));
	}
}
