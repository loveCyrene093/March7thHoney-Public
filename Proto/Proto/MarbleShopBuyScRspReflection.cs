using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MarbleShopBuyScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MarbleShopBuyScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhNYXJibGVTaG9wQnV5U2NSc3AucHJvdG8iOgoSTWFyYmxlU2hvcEJ1eVNj" + "UnNwEhMKC05MT0lOTU9EQkxFGAQgAygNEg8KB3JldGNvZGUYDSABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MarbleShopBuyScRsp), MarbleShopBuyScRsp.Parser, new string[2] { "NLOINMODBLE", "Retcode" }, null, null, null, null)
		}));
	}
}
