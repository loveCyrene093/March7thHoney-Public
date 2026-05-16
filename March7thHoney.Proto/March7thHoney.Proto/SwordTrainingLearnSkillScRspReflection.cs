using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingLearnSkillScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingLearnSkillScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nTGVhcm5Ta2lsbFNjUnNwLnByb3RvIkEKHFN3b3Jk" + "VHJhaW5pbmdMZWFyblNraWxsU2NSc3ASEAoIc2tpbGxfaWQYASABKA0SDwoH" + "cmV0Y29kZRgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingLearnSkillScRsp), SwordTrainingLearnSkillScRsp.Parser, new string[2] { "SkillId", "Retcode" }, null, null, null, null)
		}));
	}
}
