using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleMonsterReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleMonsterReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChNCYXR0bGVNb25zdGVyLnByb3RvGhFDQkNCSkNQUE9NUC5wcm90byJlCg1C" + "YXR0bGVNb25zdGVyEhIKCm1vbnN0ZXJfaWQYASABKA0SDgoGY3VyX2hwGAIg" + "ASgNEg4KBm1heF9ocBgDIAEoDRIgCgpleHRyYV9pbmZvGAQgASgLMgwuQ0JD" + "QkpDUFBPTVBCFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { CBCBJCPPOMPReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleMonster), BattleMonster.Parser, new string[4] { "MonsterId", "CurHp", "MaxHp", "ExtraInfo" }, null, null, null, null)
		}));
	}
}
