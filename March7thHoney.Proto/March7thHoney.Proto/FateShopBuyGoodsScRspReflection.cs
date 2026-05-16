using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopBuyGoodsScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopBuyGoodsScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtGYXRlU2hvcEJ1eUdvb2RzU2NSc3AucHJvdG8iPQoVRmF0ZVNob3BCdXlH" + "b29kc1NjUnNwEhMKC0NBUE5ORUdGR0JQGAcgASgNEg8KB3JldGNvZGUYCCAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopBuyGoodsScRsp), FateShopBuyGoodsScRsp.Parser, new string[2] { "CAPNNEGFGBP", "Retcode" }, null, null, null, null)
		}));
	}
}
