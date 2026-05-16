using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSummonActivityStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSummonActivityStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiNFbnRlclN1bW1vbkFjdGl2aXR5U3RhZ2VTY1JzcC5wcm90bxoVU2NlbmVC";
		buffer[1] = "YXR0bGVJbmZvLnByb3RvIn4KHUVudGVyU3VtbW9uQWN0aXZpdHlTdGFnZVNj";
		buffer[2] = "UnNwEhMKC0lOT01GRkFJRU9BGAIgASgNEiUKC2JhdHRsZV9pbmZvGAQgASgL";
		buffer[3] = "MhAuU2NlbmVCYXR0bGVJbmZvEg8KB3JldGNvZGUYCCABKA0SEAoIZ3JvdXBf";
		buffer[4] = "aWQYDSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSummonActivityStageScRsp), EnterSummonActivityStageScRsp.Parser, new string[4] { "INOMFFAIEOA", "BattleInfo", "Retcode", "GroupId" }, null, null, null, null)
		}));
	}
}
