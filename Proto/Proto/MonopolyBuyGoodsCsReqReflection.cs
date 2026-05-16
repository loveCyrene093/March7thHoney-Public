using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyBuyGoodsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyBuyGoodsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNb25vcG9seUJ1eUdvb2RzQ3NSZXEucHJvdG8iOgoVTW9ub3BvbHlCdXlH" + "b29kc0NzUmVxEg8KB3Nob3BfaWQYAyABKA0SEAoIZ29vZHNfaWQYCSABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyBuyGoodsCsReq), MonopolyBuyGoodsCsReq.Parser, new string[2] { "ShopId", "GoodsId" }, null, null, null, null)
		}));
	}
}
