using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HitMonsterBattleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HitMonsterBattleInfoReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChpIaXRNb25zdGVyQmF0dGxlSW5mby5wcm90bxoXTW9uc3RlckJhdHRsZVR5";
		buffer[1] = "cGUucHJvdG8iaQoUSGl0TW9uc3RlckJhdHRsZUluZm8SIAoYdGFyZ2V0X21v";
		buffer[2] = "bnN0ZXJfZW50aXR5X2lkGAUgASgNEi8KE21vbnN0ZXJfYmF0dGxlX3R5cGUY";
		buffer[3] = "CSABKA4yEi5Nb25zdGVyQmF0dGxlVHlwZUIWqgITTWFyY2g3dGhIb25leS5Q";
		buffer[4] = "cm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MonsterBattleTypeReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HitMonsterBattleInfo), HitMonsterBattleInfo.Parser, new string[2] { "TargetMonsterEntityId", "MonsterBattleType" }, null, null, null, null)
		}));
	}
}
