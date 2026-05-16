using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BAFDFBJHLGKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BAFDFBJHLGKReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFCQUZERkJKSExHSy5wcm90bxoWQWV0aGVyQXZhdGFySW5mby5wcm90bxoQ";
		buffer[1] = "QmF0dGxlQnVmZi5wcm90bxoXQmF0dGxlTW9uc3RlcldhdmUucHJvdG8ihAEK";
		buffer[2] = "C0JBRkRGQkpITEdLEiYKC2F2YXRhcl9saXN0GAEgAygLMhEuQWV0aGVyQXZh";
		buffer[3] = "dGFySW5mbxItChFtb25zdGVyX3dhdmVfbGlzdBgCIAMoCzISLkJhdHRsZU1v";
		buffer[4] = "bnN0ZXJXYXZlEh4KCWJ1ZmZfbGlzdBgDIAMoCzILLkJhdHRsZUJ1ZmZCFqoC";
		buffer[5] = "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			AetherAvatarInfoReflection.Descriptor,
			BattleBuffReflection.Descriptor,
			BattleMonsterWaveReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BAFDFBJHLGK), BAFDFBJHLGK.Parser, new string[3] { "AvatarList", "MonsterWaveList", "BuffList" }, null, null, null, null)
		}));
	}
}
