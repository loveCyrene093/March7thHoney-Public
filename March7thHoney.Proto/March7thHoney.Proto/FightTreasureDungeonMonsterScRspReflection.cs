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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 0) = "CiZGaWdodFRyZWFzdXJlRHVuZ2Vvbk1vbnN0ZXJTY1JzcC5wcm90bxoVU2Nl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 1) = "bmVCYXR0bGVJbmZvLnByb3RvIloKIEZpZ2h0VHJlYXN1cmVEdW5nZW9uTW9u";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 2) = "c3RlclNjUnNwEiUKC2JhdHRsZV9pbmZvGAYgASgLMhAuU2NlbmVCYXR0bGVJ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 3) = "bmZvEg8KB3JldGNvZGUYCCABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray5<string>, string>(ref buffer, 4) = "BnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray5<string>, string>(in buffer, 5))), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightTreasureDungeonMonsterScRsp), FightTreasureDungeonMonsterScRsp.Parser, new string[2] { "BattleInfo", "Retcode" }, null, null, null, null)
		}));
	}
}
