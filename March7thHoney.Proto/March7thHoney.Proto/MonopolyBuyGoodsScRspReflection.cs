using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonopolyBuyGoodsScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonopolyBuyGoodsScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtNb25vcG9seUJ1eUdvb2RzU2NSc3AucHJvdG8iSwoVTW9ub3BvbHlCdXlH" + "b29kc1NjUnNwEg8KB3JldGNvZGUYASABKA0SEAoIZ29vZHNfaWQYByABKA0S" + "DwoHc2hvcF9pZBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonopolyBuyGoodsScRsp), MonopolyBuyGoodsScRsp.Parser, new string[3] { "Retcode", "GoodsId", "ShopId" }, null, null, null, null)
		}));
	}
}
