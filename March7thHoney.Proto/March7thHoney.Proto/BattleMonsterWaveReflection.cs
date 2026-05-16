using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleMonsterWaveReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleMonsterWaveReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 0) = "ChdCYXR0bGVNb25zdGVyV2F2ZS5wcm90bxoTQmF0dGxlTW9uc3Rlci5wcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 1) = "bxoYQmF0dGxlTW9uc3RlclBhcmFtLnByb3RvIpYBChFCYXR0bGVNb25zdGVy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 2) = "V2F2ZRIkCgxtb25zdGVyX2xpc3QYASADKAsyDi5CYXR0bGVNb25zdGVyEioK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 3) = "DW1vbnN0ZXJfcGFyYW0YAiABKAsyEy5CYXR0bGVNb25zdGVyUGFyYW0SFwoP";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 4) = "YmF0dGxlX3N0YWdlX2lkGAMgASgNEhYKDmJhdHRsZV93YXZlX2lkGAQgASgN";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray6<string>, string>(ref buffer, 5) = "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray6<string>, string>(in buffer, 6))), new FileDescriptor[2]
		{
			BattleMonsterReflection.Descriptor,
			BattleMonsterParamReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleMonsterWave), BattleMonsterWave.Parser, new string[4] { "MonsterList", "MonsterParam", "BattleStageId", "BattleWaveId" }, null, null, null, null)
		}));
	}
}
