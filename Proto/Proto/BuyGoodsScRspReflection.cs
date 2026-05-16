using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyGoodsScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyGoodsScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChNCdXlHb29kc1NjUnNwLnByb3RvGg5JdGVtTGlzdC5wcm90byKBAQoNQnV5";
		buffer[1] = "R29vZHNTY1JzcBIQCghnb29kc19pZBgDIAEoDRIXCg9nb29kc19idXlfdGlt";
		buffer[2] = "ZXMYBCABKA0SIwoQcmV0dXJuX2l0ZW1fbGlzdBgGIAEoCzIJLkl0ZW1MaXN0";
		buffer[3] = "Eg8KB3JldGNvZGUYByABKA0SDwoHc2hvcF9pZBgLIAEoDUIWqgITTWFyY2g3";
		buffer[4] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { ItemListReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyGoodsScRsp), BuyGoodsScRsp.Parser, new string[5] { "GoodsId", "GoodsBuyTimes", "ReturnItemList", "Retcode", "ShopId" }, null, null, null, null)
		}));
	}
}
