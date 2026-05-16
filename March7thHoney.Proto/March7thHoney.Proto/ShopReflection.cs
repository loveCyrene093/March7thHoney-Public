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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CgpTaG9wLnByb3RvGgtHb29kcy5wcm90byKgAQoEU2hvcBIaCgpnb29kc19s";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "aXN0GAEgAygLMgYuR29vZHMSEAoIY2l0eV9leHAYAiABKA0SEAoIZW5kX3Rp";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "bWUYBCABKAMSHwoXY2l0eV90YWtlbl9sZXZlbF9yZXdhcmQYByABKAQSDwoH";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "c2hvcF9pZBgIIAEoDRISCgpiZWdpbl90aW1lGA0gASgDEhIKCmNpdHlfbGV2";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "ZWwYDiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { GoodsReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(Shop), Shop.Parser, new string[7] { "GoodsList", "CityExp", "EndTime", "CityTakenLevelReward", "ShopId", "BeginTime", "CityLevel" }, null, null, null, null)
		}));
	}
}
