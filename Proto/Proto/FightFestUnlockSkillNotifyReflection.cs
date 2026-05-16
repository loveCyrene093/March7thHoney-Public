using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FightFestUnlockSkillNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FightFestUnlockSkillNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBGaWdodEZlc3RVbmxvY2tTa2lsbE5vdGlmeS5wcm90byIxChpGaWdodEZl" + "c3RVbmxvY2tTa2lsbE5vdGlmeRITCgtPSUJIRUtBRExMTxgFIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FightFestUnlockSkillNotify), FightFestUnlockSkillNotify.Parser, new string[1] { "OIBHEKADLLO" }, null, null, null, null)
		}));
	}
}
