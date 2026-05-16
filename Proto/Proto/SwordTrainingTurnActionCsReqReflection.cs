using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingTurnActionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingTurnActionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nVHVybkFjdGlvbkNzUmVxLnByb3RvIkgKHFN3b3Jk" + "VHJhaW5pbmdUdXJuQWN0aW9uQ3NSZXESEwoLQUNCSU1PR05LQUoYCiADKA0S" + "EwoLQUtISkZLTlBHRUUYDiADKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingTurnActionCsReq), SwordTrainingTurnActionCsReq.Parser, new string[2] { "ACBIMOGNKAJ", "AKHJFKNPGEE" }, null, null, null, null)
		}));
	}
}
