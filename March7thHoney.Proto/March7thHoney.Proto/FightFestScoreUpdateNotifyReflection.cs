using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightFestScoreUpdateNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightFestScoreUpdateNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBGaWdodEZlc3RTY29yZVVwZGF0ZU5vdGlmeS5wcm90byJDChpGaWdodEZl" + "c3RTY29yZVVwZGF0ZU5vdGlmeRITCgtMTElBUEJJTExMTRgNIAEoDRIQCghz" + "Y29yZV9pZBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightFestScoreUpdateNotify), FightFestScoreUpdateNotify.Parser, new string[2] { "LLIAPBILLLM", "ScoreId" }, null, null, null, null)
		}));
	}
}
