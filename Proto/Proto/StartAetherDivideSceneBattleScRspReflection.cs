using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartAetherDivideSceneBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartAetherDivideSceneBattleScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "CidTdGFydEFldGhlckRpdmlkZVNjZW5lQmF0dGxlU2NSc3AucHJvdG8aHEFl";
		buffer[1] = "dGhlckRpdmlkZUJhdHRsZUluZm8ucHJvdG8iegohU3RhcnRBZXRoZXJEaXZp";
		buffer[2] = "ZGVTY2VuZUJhdHRsZVNjUnNwEiwKC2JhdHRsZV9pbmZvGAYgASgLMhcuQWV0";
		buffer[3] = "aGVyRGl2aWRlQmF0dGxlSW5mbxIPCgdyZXRjb2RlGAggASgNEhYKDmNhc3Rf";
		buffer[4] = "ZW50aXR5X2lkGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90";
		buffer[5] = "bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { AetherDivideBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartAetherDivideSceneBattleScRsp), StartAetherDivideSceneBattleScRsp.Parser, new string[3] { "BattleInfo", "Retcode", "CastEntityId" }, null, null, null, null)
		}));
	}
}
