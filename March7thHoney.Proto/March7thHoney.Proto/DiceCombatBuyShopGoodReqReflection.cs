using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DiceCombatBuyShopGoodReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DiceCombatBuyShopGoodReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5EaWNlQ29tYmF0QnV5U2hvcEdvb2RSZXEucHJvdG8iQAoYRGljZUNvbWJh" + "dEJ1eVNob3BHb29kUmVxEg8KB3Nob3BfaWQYByABKA0SEwoLUElNSkVERUxP" + "SE4YCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DiceCombatBuyShopGoodReq), DiceCombatBuyShopGoodReq.Parser, new string[2] { "ShopId", "PIMJEDELOHN" }, null, null, null, null)
		}));
	}
}
