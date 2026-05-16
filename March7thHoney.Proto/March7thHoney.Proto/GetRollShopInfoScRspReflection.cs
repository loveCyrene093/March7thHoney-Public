using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRollShopInfoScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRollShopInfoScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRSb2xsU2hvcEluZm9TY1JzcC5wcm90byJvChRHZXRSb2xsU2hvcElu" + "Zm9TY1JzcBIaChJzaG9wX2dyb3VwX2lkX2xpc3QYAiADKA0SFAoMZ2FjaGFf" + "cmFuZG9tGAMgASgNEhQKDHJvbGxfc2hvcF9pZBgHIAEoDRIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRollShopInfoScRsp), GetRollShopInfoScRsp.Parser, new string[4] { "ShopGroupIdList", "GachaRandom", "RollShopId", "Retcode" }, null, null, null, null)
		}));
	}
}
