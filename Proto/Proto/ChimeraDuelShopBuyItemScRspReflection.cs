using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelShopBuyItemScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelShopBuyItemScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGltZXJhRHVlbFNob3BCdXlJdGVtU2NSc3AucHJvdG8iLgobQ2hpbWVy" + "YUR1ZWxTaG9wQnV5SXRlbVNjUnNwEg8KB3JldGNvZGUYAyABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelShopBuyItemScRsp), ChimeraDuelShopBuyItemScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
