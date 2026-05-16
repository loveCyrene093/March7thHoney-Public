using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneMonsterReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneMonsterReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJTY2VuZU1vbnN0ZXIucHJvdG8aEU1FSEFPTUdCT01DLnByb3RvImQKDFNj" + "ZW5lTW9uc3RlchIOCgZtYXhfaHAYByABKA0SIAoKZXh0cmFfaW5mbxgIIAEo" + "CzIMLk1FSEFPTUdCT01DEg4KBmN1cl9ocBgLIAEoDRISCgptb25zdGVyX2lk" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { MEHAOMGBOMCReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneMonster), SceneMonster.Parser, new string[4] { "MaxHp", "ExtraInfo", "CurHp", "MonsterId" }, null, null, null, null)
		}));
	}
}
