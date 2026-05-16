using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopLockGoodsScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopLockGoodsScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxGYXRlU2hvcExvY2tHb29kc1NjUnNwLnByb3RvIjwKFkZhdGVTaG9wTG9j" + "a0dvb2RzU2NSc3ASEQoJaXNfbG9ja2VkGAQgASgIEg8KB3JldGNvZGUYByAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopLockGoodsScRsp), FateShopLockGoodsScRsp.Parser, new string[2] { "IsLocked", "Retcode" }, null, null, null, null)
		}));
	}
}
