using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class StartCocoonStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static StartCocoonStageScRspReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChtTdGFydENvY29vblN0YWdlU2NSc3AucHJvdG8aFVNjZW5lQmF0dGxlSW5m";
		buffer[1] = "by5wcm90byKfAQoVU3RhcnRDb2Nvb25TdGFnZVNjUnNwEgwKBHdhdmUYBCAB";
		buffer[2] = "KA0SDwoHcmV0Y29kZRgFIAEoDRIWCg5wcm9wX2VudGl0eV9pZBgGIAEoDRIV";
		buffer[3] = "Cg1jaGFsbGVuZ2VfY250GAkgASgNEiUKC2JhdHRsZV9pbmZvGAsgASgLMhAu";
		buffer[4] = "U2NlbmVCYXR0bGVJbmZvEhEKCWNvY29vbl9pZBgOIAEoDUIWqgITTWFyY2g3";
		buffer[5] = "dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(StartCocoonStageScRsp), StartCocoonStageScRsp.Parser, new string[6] { "Wave", "Retcode", "PropEntityId", "ChallengeCnt", "BattleInfo", "CocoonId" }, null, null, null, null)
		}));
	}
}
