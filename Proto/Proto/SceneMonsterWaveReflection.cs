using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneMonsterWaveReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneMonsterWaveReflection()
	{
		InlineArray7<string> buffer = default(InlineArray7<string>);
		buffer[0] = "ChZTY2VuZU1vbnN0ZXJXYXZlLnByb3RvGg5JdGVtTGlzdC5wcm90bxoSU2Nl";
		buffer[1] = "bmVNb25zdGVyLnByb3RvGhtTY2VuZU1vbnN0ZXJXYXZlUGFyYW0ucHJvdG8i";
		buffer[2] = "twEKEFNjZW5lTW9uc3RlcldhdmUSFwoPYmF0dGxlX3N0YWdlX2lkGAMgASgN";
		buffer[3] = "EiMKDG1vbnN0ZXJfbGlzdBgGIAMoCzINLlNjZW5lTW9uc3RlchIeCgtQSUJM";
		buffer[4] = "SkxCQ0tKTBgJIAMoCzIJLkl0ZW1MaXN0Ei0KDW1vbnN0ZXJfcGFyYW0YDCAB";
		buffer[5] = "KAsyFi5TY2VuZU1vbnN0ZXJXYXZlUGFyYW0SFgoOYmF0dGxlX3dhdmVfaWQY";
		buffer[6] = "DiABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[3]
		{
			ItemListReflection.Descriptor,
			SceneMonsterReflection.Descriptor,
			SceneMonsterWaveParamReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneMonsterWave), SceneMonsterWave.Parser, new string[5] { "BattleStageId", "MonsterList", "PIBLJLBCKJL", "MonsterParam", "BattleWaveId" }, null, null, null, null)
		}));
	}
}
