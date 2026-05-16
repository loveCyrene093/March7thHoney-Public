using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightBuyGoodsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightBuyGoodsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHcmlkRmlnaHRCdXlHb29kc0NzUmVxLnByb3RvIjYKFkdyaWRGaWdodEJ1" + "eUdvb2RzQ3NSZXESHAoUYnV5X2dvb2RzX2luZGV4X2xpc3QYAyADKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightBuyGoodsCsReq), GridFightBuyGoodsCsReq.Parser, new string[1] { "BuyGoodsIndexList" }, null, null, null, null)
		}));
	}
}
