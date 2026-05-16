using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChimeraDuelShopRefreshCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChimeraDuelShopRefreshCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFDaGltZXJhRHVlbFNob3BSZWZyZXNoQ3NSZXEucHJvdG8iHQobQ2hpbWVy" + "YUR1ZWxTaG9wUmVmcmVzaENzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChimeraDuelShopRefreshCsReq), ChimeraDuelShopRefreshCsReq.Parser, null, null, null, null, null)
		}));
	}
}
