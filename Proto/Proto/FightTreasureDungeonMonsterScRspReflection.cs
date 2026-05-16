using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightTreasureDungeonMonsterScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightTreasureDungeonMonsterScRspReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CiZGaWdodFRyZWFzdXJlRHVuZ2Vvbk1vbnN0ZXJTY1JzcC5wcm90bxoVU2Nl";
		buffer[1] = "bmVCYXR0bGVJbmZvLnByb3RvIloKIEZpZ2h0VHJlYXN1cmVEdW5nZW9uTW9u";
		buffer[2] = "c3RlclNjUnNwEiUKC2JhdHRsZV9pbmZvGAYgASgLMhAuU2NlbmVCYXR0bGVJ";
		buffer[3] = "bmZvEg8KB3JldGNvZGUYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		buffer[4] = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightTreasureDungeonMonsterScRsp), FightTreasureDungeonMonsterScRsp.Parser, new string[2] { "BattleInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
