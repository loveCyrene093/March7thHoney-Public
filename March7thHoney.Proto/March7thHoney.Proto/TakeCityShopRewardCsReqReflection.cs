using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TakeCityShopRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TakeCityShopRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1UYWtlQ2l0eVNob3BSZXdhcmRDc1JlcS5wcm90byI5ChdUYWtlQ2l0eVNo" + "b3BSZXdhcmRDc1JlcRIPCgdzaG9wX2lkGAQgASgNEg0KBWxldmVsGA0gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TakeCityShopRewardCsReq), TakeCityShopRewardCsReq.Parser, new string[2] { "ShopId", "Level" }, null, null, null, null)
		}));
	}
}
