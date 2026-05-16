using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SceneEnterStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SceneEnterStageScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTY2VuZUVudGVyU3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVCYXR0bGVJbmZv" + "LnByb3RvIk4KFFNjZW5lRW50ZXJTdGFnZVNjUnNwEiUKC2JhdHRsZV9pbmZv" + "GAEgASgLMhAuU2NlbmVCYXR0bGVJbmZvEg8KB3JldGNvZGUYDiABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SceneEnterStageScRsp), SceneEnterStageScRsp.Parser, new string[2] { "BattleInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
