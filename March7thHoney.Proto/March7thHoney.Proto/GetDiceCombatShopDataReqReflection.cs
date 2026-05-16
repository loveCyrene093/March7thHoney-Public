using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetDiceCombatShopDataReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetDiceCombatShopDataReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXREaWNlQ29tYmF0U2hvcERhdGFSZXEucHJvdG8iGgoYR2V0RGljZUNv" + "bWJhdFNob3BEYXRhUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetDiceCombatShopDataReq), GetDiceCombatShopDataReq.Parser, null, null, null, null, null)
		}));
	}
}
