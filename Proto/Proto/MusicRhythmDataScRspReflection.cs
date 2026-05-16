using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MusicRhythmDataScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MusicRhythmDataScRspReflection()
	{
		InlineArray9<string> buffer = default(InlineArray9<string>);
		buffer[0] = "ChpNdXNpY1JoeXRobURhdGFTY1JzcC5wcm90bxoWTXVzaWNSaHl0aG1Hcm91";
		buffer[1] = "cC5wcm90bxoWTXVzaWNSaHl0aG1MZXZlbC5wcm90byKJAgoUTXVzaWNSaHl0";
		buffer[2] = "aG1EYXRhU2NSc3ASKgoPbGV2ZWxfZGF0YV9saXN0GAEgAygLMhEuTXVzaWNS";
		buffer[3] = "aHl0aG1MZXZlbBIZChF1bmxvY2tfcGhhc2VfbGlzdBgDIAMoDRIRCglzaG93";
		buffer[4] = "X2hpbnQYBSABKAgSGQoRdW5sb2NrX3RyYWNrX2xpc3QYBiADKA0SJgoLbXVz";
		buffer[5] = "aWNfZ3JvdXAYCCADKAsyES5NdXNpY1JoeXRobUdyb3VwEg8KB3JldGNvZGUY";
		buffer[6] = "CiABKA0SFAoMY3VyX2xldmVsX2lkGAsgASgNEhgKEHVubG9ja19zb25nX2xp";
		buffer[7] = "c3QYDCADKA0SEwoLY3VyX3NvbmdfaWQYDiABKA1CFqoCE01hcmNoN3RoSG9u";
		buffer[8] = "ZXkuUHJvdG9iBnByb3RvMw==";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[2]
		{
			MusicRhythmGroupReflection.Descriptor,
			MusicRhythmLevelReflection.Descriptor
		}, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MusicRhythmDataScRsp), MusicRhythmDataScRsp.Parser, new string[9] { "LevelDataList", "UnlockPhaseList", "ShowHint", "UnlockTrackList", "MusicGroup", "Retcode", "CurLevelId", "UnlockSongList", "CurSongId" }, null, null, null, null)
		}));
	}
}
