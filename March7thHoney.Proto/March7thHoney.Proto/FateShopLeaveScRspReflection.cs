using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopLeaveScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopLeaveScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGYXRlU2hvcExlYXZlU2NSc3AucHJvdG8iJQoSRmF0ZVNob3BMZWF2ZVNj" + "UnNwEg8KB3JldGNvZGUYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopLeaveScRsp), FateShopLeaveScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
