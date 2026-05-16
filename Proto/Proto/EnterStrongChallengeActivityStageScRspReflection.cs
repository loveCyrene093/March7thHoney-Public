using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterStrongChallengeActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterStrongChallengeActivityStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CixFbnRlclN0cm9uZ0NoYWxsZW5nZUFjdGl2aXR5U3RhZ2VTY1JzcC5wcm90";
		buffer[1] = "bxoVU2NlbmVCYXR0bGVJbmZvLnByb3RvInIKJkVudGVyU3Ryb25nQ2hhbGxl";
		buffer[2] = "bmdlQWN0aXZpdHlTdGFnZVNjUnNwEg8KB3JldGNvZGUYBSABKA0SEAoIc3Rh";
		buffer[3] = "Z2VfaWQYCCABKA0SJQoLYmF0dGxlX2luZm8YDiABKAsyEC5TY2VuZUJhdHRs";
		buffer[4] = "ZUluZm9CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterStrongChallengeActivityStageScRsp), EnterStrongChallengeActivityStageScRsp.Parser, new string[3] { "Retcode", "StageId", "BattleInfo" }, null, null, null, null)
		}));
	}
}
