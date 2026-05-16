using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto.ServerSide;

public static class ChallengeDataReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeDataReflection()
	{
		_003C_003Ey__InlineArray37<string> buffer = default(_003C_003Ey__InlineArray37<string>);
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 0) = "ChNDaGFsbGVuZ2VEYXRhLnByb3RvIiwKCVZlY3RvcjNQYhIJCgF4GAEgASgF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 1) = "EgkKAXkYAiABKAUSCQoBehgDIAEoBSKUAgoVQ2hhbGxlbmdlTWVtb3J5RGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 2) = "YVBiEhcKD0NoYWxsZW5nZU1hemVJZBgBIAEoDRIcCghTdGFydFBvcxgCIAEo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 3) = "CzIKLlZlY3RvcjNQYhIcCghTdGFydFJvdBgDIAEoCzIKLlZlY3RvcjNQYhIU";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 4) = "CgxDdXJyZW50U3RhZ2UYBCABKA0SEQoJQ3VyU3RhdHVzGAUgASgNEhUKDURl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 5) = "YWRBdmF0YXJOdW0YBiABKA0SDwoHU2F2ZWRNcBgHIAEoDRIyChJDdXJyZW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 6) = "RXh0cmFMaW5ldXAYCCABKA4yFi5DaGFsbGVuZ2VMaW5ldXBUeXBlUGISEgoK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 7) = "Um91bmRzTGVmdBgJIAEoDRINCgVTdGFycxgKIAEoDSKhAgoUQ2hhbGxlbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 8) = "U3RvcnlEYXRhUGISFwoPQ2hhbGxlbmdlTWF6ZUlkGAEgASgNEhwKCFN0YXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 9) = "UG9zGAIgASgLMgouVmVjdG9yM1BiEhwKCFN0YXJ0Um90GAMgASgLMgouVmVj";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 10) = "dG9yM1BiEhQKDEN1cnJlbnRTdGFnZRgEIAEoDRIRCglDdXJTdGF0dXMYBSAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 11) = "KA0SDwoHU2F2ZWRNcBgGIAEoDRIyChJDdXJyZW50RXh0cmFMaW5ldXAYByAB";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 12) = "KA4yFi5DaGFsbGVuZ2VMaW5ldXBUeXBlUGISDQoFU3RhcnMYCCABKA0SEwoL";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 13) = "U2NvcmVTdGFnZTEYCSABKA0SEwoLU2NvcmVTdGFnZTIYCiABKA0SDQoFQnVm";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 14) = "ZnMYCyADKA0ioAIKE0NoYWxsZW5nZUJvc3NEYXRhUGISFwoPQ2hhbGxlbmdl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 15) = "TWF6ZUlkGAEgASgNEhwKCFN0YXJ0UG9zGAIgASgLMgouVmVjdG9yM1BiEhwK";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 16) = "CFN0YXJ0Um90GAMgASgLMgouVmVjdG9yM1BiEhQKDEN1cnJlbnRTdGFnZRgE";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 17) = "IAEoDRIRCglDdXJTdGF0dXMYBSABKA0SDwoHU2F2ZWRNcBgGIAEoDRIyChJD";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 18) = "dXJyZW50RXh0cmFMaW5ldXAYByABKA4yFi5DaGFsbGVuZ2VMaW5ldXBUeXBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 19) = "UGISDQoFU3RhcnMYCCABKA0SEwoLU2NvcmVTdGFnZTEYCSABKA0SEwoLU2Nv";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 20) = "cmVTdGFnZTIYCiABKA0SDQoFQnVmZnMYCyADKA0ioQIKE0NoYWxsZW5nZVBl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 21) = "YWtEYXRhUGISGgoSQ3VycmVudFBlYWtHcm91cElkGAEgASgNEhoKEkN1cnJl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 22) = "bnRQZWFrTGV2ZWxJZBgCIAEoDRINCgVCdWZmcxgDIAMoDRIRCglDdXJTdGF0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 23) = "dXMYBCABKA0SHAoIU3RhcnRQb3MYBSABKAsyCi5WZWN0b3IzUGISHAoIU3Rh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 24) = "cnRSb3QYBiABKAsyCi5WZWN0b3IzUGISDwoHU2F2ZWRNcBgHIAEoDRINCgVT";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 25) = "dGFycxgIIAEoDRIyChJDdXJyZW50RXh0cmFMaW5ldXAYCSABKA4yFi5DaGFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 26) = "bGVuZ2VMaW5ldXBUeXBlUGISDgoGSXNIYXJkGAogASgIEhAKCFJvdW5kQ250";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 27) = "GAsgASgNIsEBCg9DaGFsbGVuZ2VEYXRhUGISKAoGbWVtb3J5GAEgASgLMhYu";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 28) = "Q2hhbGxlbmdlTWVtb3J5RGF0YVBiSAASJgoFc3RvcnkYAiABKAsyFS5DaGFs";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 29) = "bGVuZ2VTdG9yeURhdGFQYkgAEiQKBGJvc3MYAyABKAsyFC5DaGFsbGVuZ2VC";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 30) = "b3NzRGF0YVBiSAASJAoEcGVhaxgEIAEoCzIULkNoYWxsZW5nZVBlYWtEYXRh";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 31) = "UGJIAEIQCg5jaGFsbGVuZ2VfdHlwZSqpAQoVQ2hhbGxlbmdlTGluZXVwVHlw";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 32) = "ZVBiEh4KGkNoYWxsZW5nZUxpbmV1cFR5cGVQYl9Ob25lEAASJAogQ2hhbGxl";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 33) = "bmdlTGluZXVwVHlwZVBiX0NoYWxsZW5nZTEQARIkCiBDaGFsbGVuZ2VMaW5l";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 34) = "dXBUeXBlUGJfQ2hhbGxlbmdlMhADEiQKIENoYWxsZW5nZUxpbmV1cFR5cGVQ";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 35) = "Yl9DaGFsbGVuZ2UzEARCKaoCJkVnZ0xpbmsuRGFuaGVuZ1NlcnZlci5Qcm90";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<_003C_003Ey__InlineArray37<string>, string>(ref buffer, 36) = "by5TZXJ2ZXJTaWRlYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<_003C_003Ey__InlineArray37<string>, string>(in buffer, 37))), new FileDescriptor[0], new GeneratedClrTypeInfo(new Type[1] { typeof(ChallengeLineupTypePb) }, null, new GeneratedClrTypeInfo[6]
		{
			new GeneratedClrTypeInfo(typeof(Vector3Pb), Vector3Pb.Parser, new string[3] { "X", "Y", "Z" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(ChallengeMemoryDataPb), ChallengeMemoryDataPb.Parser, new string[10] { "ChallengeMazeId", "StartPos", "StartRot", "CurrentStage", "CurStatus", "DeadAvatarNum", "SavedMp", "CurrentExtraLineup", "RoundsLeft", "Stars" }, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(ChallengeStoryDataPb), ChallengeStoryDataPb.Parser, new string[11]
			{
				"ChallengeMazeId", "StartPos", "StartRot", "CurrentStage", "CurStatus", "SavedMp", "CurrentExtraLineup", "Stars", "ScoreStage1", "ScoreStage2",
				"Buffs"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(ChallengeBossDataPb), ChallengeBossDataPb.Parser, new string[11]
			{
				"ChallengeMazeId", "StartPos", "StartRot", "CurrentStage", "CurStatus", "SavedMp", "CurrentExtraLineup", "Stars", "ScoreStage1", "ScoreStage2",
				"Buffs"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(ChallengePeakDataPb), ChallengePeakDataPb.Parser, new string[11]
			{
				"CurrentPeakGroupId", "CurrentPeakLevelId", "Buffs", "CurStatus", "StartPos", "StartRot", "SavedMp", "Stars", "CurrentExtraLineup", "IsHard",
				"RoundCnt"
			}, null, null, null, null),
			new GeneratedClrTypeInfo(typeof(ChallengeDataPb), ChallengeDataPb.Parser, new string[4] { "Memory", "Story", "Boss", "Peak" }, new string[1] { "ChallengeType" }, null, null, null)
		}));
	}
}
