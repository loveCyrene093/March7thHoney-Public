using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingLearnSkillCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingLearnSkillCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nTGVhcm5Ta2lsbENzUmVxLnByb3RvIjAKHFN3b3Jk" + "VHJhaW5pbmdMZWFyblNraWxsQ3NSZXESEAoIc2tpbGxfaWQYByABKA1CFqoC" + "E01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingLearnSkillCsReq), SwordTrainingLearnSkillCsReq.Parser, new string[1] { "SkillId" }, null, null, null, null)
		}));
	}
}
