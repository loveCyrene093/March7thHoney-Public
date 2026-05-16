using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BuyShopGoodScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BuyShopGoodScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZCdXlTaG9wR29vZFNjUnNwLnByb3RvGhFJR0ZIRkJBRkRETy5wcm90byJG" + "ChBCdXlTaG9wR29vZFNjUnNwEg8KB3JldGNvZGUYBCABKA0SIQoLT0NFUEZP" + "SUhMQkgYDiADKAsyDC5JR0ZIRkJBRkRET0IWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[1] { IGFHFBAFDDOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BuyShopGoodScRsp), BuyShopGoodScRsp.Parser, new string[2] { "Retcode", "OCEPFOIHLBH" }, null, null, null, null)
		}));
	}
}
