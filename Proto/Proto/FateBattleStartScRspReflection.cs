using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FateBattleStartScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FateBattleStartScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpGYXRlQmF0dGxlU3RhcnRTY1JzcC5wcm90bxoVU2NlbmVCYXR0bGVJbmZv" + "LnByb3RvIk4KFEZhdGVCYXR0bGVTdGFydFNjUnNwEg8KB3JldGNvZGUYByAB" + "KA0SJQoLYmF0dGxlX2luZm8YCSABKAsyEC5TY2VuZUJhdHRsZUluZm9CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FateBattleStartScRsp), FateBattleStartScRsp.Parser, new string[2] { "Retcode", "BattleInfo" }, null, null, null, null)
		}));
	}
}
