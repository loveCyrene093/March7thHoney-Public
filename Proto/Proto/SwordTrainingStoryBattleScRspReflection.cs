using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingStoryBattleScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingStoryBattleScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiNTd29yZFRyYWluaW5nU3RvcnlCYXR0bGVTY1JzcC5wcm90bxoVU2NlbmVC";
		buffer[1] = "YXR0bGVJbmZvLnByb3RvIlcKHVN3b3JkVHJhaW5pbmdTdG9yeUJhdHRsZVNj";
		buffer[2] = "UnNwEg8KB3JldGNvZGUYAyABKA0SJQoLYmF0dGxlX2luZm8YDyABKAsyEC5T";
		buffer[3] = "Y2VuZUJhdHRsZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3Rv";
		buffer[4] = "Mw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingStoryBattleScRsp), SwordTrainingStoryBattleScRsp.Parser, new string[2] { "Retcode", "BattleInfo" }, null, null, null, null)
		}));
	}
}
