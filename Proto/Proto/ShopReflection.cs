using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ShopReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ShopReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CgpTaG9wLnByb3RvGgtHb29kcy5wcm90byKgAQoEU2hvcBIaCgpnb29kc19s";
		buffer[1] = "aXN0GAEgAygLMgYuR29vZHMSEAoIY2l0eV9leHAYAiABKA0SEAoIZW5kX3Rp";
		buffer[2] = "bWUYBCABKAMSHwoXY2l0eV90YWtlbl9sZXZlbF9yZXdhcmQYByABKAQSDwoH";
		buffer[3] = "c2hvcF9pZBgIIAEoDRISCgpiZWdpbl90aW1lGA0gASgDEhIKCmNpdHlfbGV2";
		buffer[4] = "ZWwYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { GoodsReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Shop), Shop.Parser, new string[7] { "GoodsList", "CityExp", "EndTime", "CityTakenLevelReward", "ShopId", "BeginTime", "CityLevel" }, null, null, null, null)
		}));
	}
}
