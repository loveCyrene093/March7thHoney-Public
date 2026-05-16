using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopRefreshGoodsScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopRefreshGoodsScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "Ch9GYXRlU2hvcFJlZnJlc2hHb29kc1NjUnNwLnByb3RvGhFKQ0ZEQ0VLTEJG";
		buffer[1] = "SC5wcm90byJoChlGYXRlU2hvcFJlZnJlc2hHb29kc1NjUnNwEhMKC0VCS0xQ";
		buffer[2] = "S05BTkxOGAIgASgIEiUKD3Nob3BfZ29vZHNfbGlzdBgLIAMoCzIMLkpDRkRD";
		buffer[3] = "RUtMQkZIEg8KB3JldGNvZGUYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJv";
		buffer[4] = "dG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { JCFDCEKLBFHReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopRefreshGoodsScRsp), FateShopRefreshGoodsScRsp.Parser, new string[3] { "EBKLPKNANLN", "ShopGoodsList", "Retcode" }, null, null, null, null)
		}));
	}
}
