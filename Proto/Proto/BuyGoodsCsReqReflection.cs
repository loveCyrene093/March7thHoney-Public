using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyGoodsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyGoodsCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChNCdXlHb29kc0NzUmVxLnByb3RvIo4BCg1CdXlHb29kc0NzUmVxEhAKCGdv";
		buffer[1] = "b2RzX2lkGAUgASgNEiEKGWludGVyYWN0ZWRfcHJvcF9lbnRpdHlfaWQYBiAB";
		buffer[2] = "KA0SEQoJZ29vZHNfbnVtGAggASgNEg8KB2l0ZW1faWQYDSABKA0SEwoLTElJ";
		buffer[3] = "QkFFTUFIT0IYDiADKA0SDwoHc2hvcF9pZBgPIAEoDUIWqgITTWFyY2g3dGhI";
		buffer[4] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyGoodsCsReq), BuyGoodsCsReq.Parser, new string[6] { "GoodsId", "InteractedPropEntityId", "GoodsNum", "ItemId", "LIIBAEMAHOB", "ShopId" }, null, null, null, null)
		}));
	}
}
