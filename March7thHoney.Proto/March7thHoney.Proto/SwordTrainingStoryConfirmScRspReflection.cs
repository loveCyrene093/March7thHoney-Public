using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingStoryConfirmScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingStoryConfirmScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRTd29yZFRyYWluaW5nU3RvcnlDb25maXJtU2NSc3AucHJvdG8iRgoeU3dv" + "cmRUcmFpbmluZ1N0b3J5Q29uZmlybVNjUnNwEhMKC01BRk1DSVBBSUtLGAMg" + "ASgNEg8KB3JldGNvZGUYBSABKA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9i" + "BnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingStoryConfirmScRsp), SwordTrainingStoryConfirmScRsp.Parser, new string[2] { "MAFMCIPAIKK", "Retcode" }, null, null, null, null)
		}));
	}
}
