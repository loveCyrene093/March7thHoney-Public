using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingGiveUpGameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingGiveUpGameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nR2l2ZVVwR2FtZUNzUmVxLnByb3RvIh4KHFN3b3Jk" + "VHJhaW5pbmdHaXZlVXBHYW1lQ3NSZXFCFqoCE01hcmNoN3RoSG9uZXkuUHJv" + "dG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingGiveUpGameCsReq), SwordTrainingGiveUpGameCsReq.Parser, null, null, null, null, null)
		}));
	}
}
