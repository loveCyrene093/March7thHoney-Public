using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopSellBuffScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopSellBuffScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtGYXRlU2hvcFNlbGxCdWZmU2NSc3AucHJvdG8iZwoVRmF0ZVNob3BTZWxs" + "QnVmZlNjUnNwEg8KB3JldGNvZGUYAiABKA0SEwoLTlBNQUFOT09DT0oYCCAB" + "KA0SEwoLUEhHQ0RBT0hMREEYDSABKAgSEwoLT0lCUExNS0tHR0wYDyABKA1C" + "FqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopSellBuffScRsp), FateShopSellBuffScRsp.Parser, new string[4] { "Retcode", "NPMAANOOCOJ", "PHGCDAOHLDA", "OIBPLMKKGGL" }, null, null, null, null)
		}));
	}
}
