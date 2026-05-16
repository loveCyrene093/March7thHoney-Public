using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingBuyShopItemCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingBuyShopItemCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5DaGVuTGluZ0J1eVNob3BJdGVtQ3NSZXEucHJvdG8iLwoYQ2hlbkxpbmdC" + "dXlTaG9wSXRlbUNzUmVxEhMKC0FPQUFORU9NT09PGAMgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingBuyShopItemCsReq), ChenLingBuyShopItemCsReq.Parser, new string[1] { "AOAANEOMOOO" }, null, null, null, null)
		}));
	}
}
