using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MonsterListReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MonsterListReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNb25zdGVyTGlzdC5wcm90byIuCgtNb25zdGVyTGlzdBILCgNudW0YAyAB" + "KA0SEgoKbW9uc3Rlcl9pZBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MonsterList), MonsterList.Parser, new string[2] { "Num", "MonsterId" }, null, null, null, null)
		}));
	}
}
