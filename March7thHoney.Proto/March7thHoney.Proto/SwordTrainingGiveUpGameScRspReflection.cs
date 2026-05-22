using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingGiveUpGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingGiveUpGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nR2l2ZVVwR2FtZVNjUnNwLnByb3RvIi8KHFN3b3Jk" + "VHJhaW5pbmdHaXZlVXBHYW1lU2NSc3ASDwoHcmV0Y29kZRgIIAEoDUIWqgIT" + "TWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingGiveUpGameScRsp), SwordTrainingGiveUpGameScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
