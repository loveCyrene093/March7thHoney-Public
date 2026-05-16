using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ElfRestaurantBuyShopItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ElfRestaurantBuyShopItemScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CiNFbGZSZXN0YXVyYW50QnV5U2hvcEl0ZW1TY1JzcC5wcm90bxoSSXRlbUNv";
		buffer[1] = "c3REYXRhLnByb3RvGg5JdGVtTGlzdC5wcm90byKJAQodRWxmUmVzdGF1cmFu";
		buffer[2] = "dEJ1eVNob3BJdGVtU2NSc3ASIgoLS0JFRktPTlBLR0oYASABKAsyDS5JdGVt";
		buffer[3] = "Q29zdERhdGESEwoLTkdCTklQRU1ITUQYAiABKA0SHgoLUFBNQUZDQk5BSkYY";
		buffer[4] = "BCABKAsyCS5JdGVtTGlzdBIPCgdyZXRjb2RlGA0gASgNQhaqAhNNYXJjaDd0";
		buffer[5] = "aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			ItemCostDataReflection.Descriptor,
			ItemListReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ElfRestaurantBuyShopItemScRsp), ElfRestaurantBuyShopItemScRsp.Parser, new string[4] { "KBEFKONPKGJ", "NGBNIPEMHMD", "PPMAFCBNAJF", "Retcode" }, null, null, null, null)
		}));
	}
}
