using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopRefreshGoodsCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopRefreshGoodsCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9GYXRlU2hvcFJlZnJlc2hHb29kc0NzUmVxLnByb3RvIhsKGUZhdGVTaG9w" + "UmVmcmVzaEdvb2RzQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnBy" + "b3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopRefreshGoodsCsReq), FateShopRefreshGoodsCsReq.Parser, null, null, null, null, null)
		}));
	}
}
