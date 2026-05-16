using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingSetSkillTraceCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingSetSkillTraceCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiVTd29yZFRyYWluaW5nU2V0U2tpbGxUcmFjZUNzUmVxLnByb3RvIjMKH1N3" + "b3JkVHJhaW5pbmdTZXRTa2lsbFRyYWNlQ3NSZXESEAoIc2tpbGxfaWQYASAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingSetSkillTraceCsReq), SwordTrainingSetSkillTraceCsReq.Parser, new string[1] { "SkillId" }, null, null, null, null)
		}));
	}
}
