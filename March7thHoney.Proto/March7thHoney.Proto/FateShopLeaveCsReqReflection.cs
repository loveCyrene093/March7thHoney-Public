using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateShopLeaveCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateShopLeaveCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhGYXRlU2hvcExlYXZlQ3NSZXEucHJvdG8iFAoSRmF0ZVNob3BMZWF2ZUNz" + "UmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateShopLeaveCsReq), FateShopLeaveCsReq.Parser, null, null, null, null, null)
		}));
	}
}
