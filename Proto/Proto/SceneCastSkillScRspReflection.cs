using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneCastSkillScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneCastSkillScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChlTY2VuZUNhc3RTa2lsbFNjUnNwLnByb3RvGhpIaXRNb25zdGVyQmF0dGxl";
		buffer[1] = "SW5mby5wcm90bxoVU2NlbmVCYXR0bGVJbmZvLnByb3RvIpkBChNTY2VuZUNh";
		buffer[2] = "c3RTa2lsbFNjUnNwEiUKC2JhdHRsZV9pbmZvGAEgASgLMhAuU2NlbmVCYXR0";
		buffer[3] = "bGVJbmZvEjIKE21vbnN0ZXJfYmF0dGxlX2luZm8YAiADKAsyFS5IaXRNb25z";
		buffer[4] = "dGVyQmF0dGxlSW5mbxIWCg5jYXN0X2VudGl0eV9pZBgEIAEoDRIPCgdyZXRj";
		buffer[5] = "b2RlGAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			HitMonsterBattleInfoReflection.Descriptor,
			SceneBattleInfoReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneCastSkillScRsp), SceneCastSkillScRsp.Parser, new string[4] { "BattleInfo", "MonsterBattleInfo", "CastEntityId", "Retcode" }, null, null, null, null)
		}));
	}
}
