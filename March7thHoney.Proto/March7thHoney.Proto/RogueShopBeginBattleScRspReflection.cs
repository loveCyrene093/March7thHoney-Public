using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueShopBeginBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueShopBeginBattleScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9Sb2d1ZVNob3BCZWdpbkJhdHRsZVNjUnNwLnByb3RvGhVTY2VuZUJhdHRs" + "ZUluZm8ucHJvdG8iUwoZUm9ndWVTaG9wQmVnaW5CYXR0bGVTY1JzcBIlCgtE" + "REhHQ0FGRkZPUBgBIAEoCzIQLlNjZW5lQmF0dGxlSW5mbxIPCgdyZXRjb2Rl" + "GAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueShopBeginBattleScRsp), RogueShopBeginBattleScRsp.Parser, new string[2] { "DDHGCAFFFOP", "Retcode" }, null, null, null, null)
		}));
	}
}
