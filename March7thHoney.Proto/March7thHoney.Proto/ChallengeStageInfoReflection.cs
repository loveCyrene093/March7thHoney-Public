using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChallengeStageInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChallengeStageInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhDaGFsbGVuZ2VTdGFnZUluZm8ucHJvdG8aF0NoYWxsZW5nZUJvc3NJbmZv" + "LnByb3RvIjsKEkNoYWxsZW5nZVN0YWdlSW5mbxIlCglib3NzX2luZm8YCyAB" + "KAsyEi5DaGFsbGVuZ2VCb3NzSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[1] { ChallengeBossInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChallengeStageInfo), ChallengeStageInfo.Parser, new string[1] { "BossInfo" }, null, null, null, null)
		}));
	}
}
