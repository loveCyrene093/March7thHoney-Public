using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RogueTournReEnterRogueCocoonStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RogueTournReEnterRogueCocoonStageScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CixSb2d1ZVRvdXJuUmVFbnRlclJvZ3VlQ29jb29uU3RhZ2VTY1JzcC5wcm90";
		buffer[1] = "bxoVU2NlbmVCYXR0bGVJbmZvLnByb3RvImAKJlJvZ3VlVG91cm5SZUVudGVy";
		buffer[2] = "Um9ndWVDb2Nvb25TdGFnZVNjUnNwEiUKC2JhdHRsZV9pbmZvGAkgASgLMhAu";
		buffer[3] = "U2NlbmVCYXR0bGVJbmZvEg8KB3JldGNvZGUYCiABKA1CFqoCE01hcmNoN3Ro";
		buffer[4] = "SG9uZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RogueTournReEnterRogueCocoonStageScRsp), RogueTournReEnterRogueCocoonStageScRsp.Parser, new string[2] { "BattleInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
