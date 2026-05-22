using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopBuyGoodsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopBuyGoodsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtGYXRlU2hvcEJ1eUdvb2RzQ3NSZXEucHJvdG8iLAoVRmF0ZVNob3BCdXlH" + "b29kc0NzUmVxEhMKC0NBUE5ORUdGR0JQGA0gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopBuyGoodsCsReq), FateShopBuyGoodsCsReq.Parser, new string[1] { "CAPNNEGFGBP" }, null, null, null, null)
		}));
	}
}
