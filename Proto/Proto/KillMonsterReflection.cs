using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KillMonsterReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KillMonsterReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLaWxsTW9uc3Rlci5wcm90byIzCgtLaWxsTW9uc3RlchISCgptb25zdGVy" + "X2lkGAYgASgNEhAKCGtpbGxfbnVtGAggASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KillMonster), KillMonster.Parser, new string[2] { "MonsterId", "KillNum" }, null, null, null, null)
		}));
	}
}
