using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopLockGoodsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopLockGoodsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxGYXRlU2hvcExvY2tHb29kc0NzUmVxLnByb3RvIisKFkZhdGVTaG9wTG9j" + "a0dvb2RzQ3NSZXESEQoJaXNfbG9ja2VkGAYgASgIQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopLockGoodsCsReq), FateShopLockGoodsCsReq.Parser, new string[1] { "IsLocked" }, null, null, null, null)
		}));
	}
}
