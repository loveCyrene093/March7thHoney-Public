using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetShopListCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetShopListCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZHZXRTaG9wTGlzdENzUmVxLnByb3RvIiUKEEdldFNob3BMaXN0Q3NSZXES" + "EQoJc2hvcF90eXBlGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetShopListCsReq), GetShopListCsReq.Parser, new string[1] { "ShopType" }, null, null, null, null)
		}));
	}
}
