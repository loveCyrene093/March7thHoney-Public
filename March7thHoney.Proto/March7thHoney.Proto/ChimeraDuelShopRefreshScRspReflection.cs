using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelShopRefreshScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelShopRefreshScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGltZXJhRHVlbFNob3BSZWZyZXNoU2NSc3AucHJvdG8iLgobQ2hpbWVy" + "YUR1ZWxTaG9wUmVmcmVzaFNjUnNwEg8KB3JldGNvZGUYDCABKA1CFqoCE01h" + "cmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelShopRefreshScRsp), ChimeraDuelShopRefreshScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
