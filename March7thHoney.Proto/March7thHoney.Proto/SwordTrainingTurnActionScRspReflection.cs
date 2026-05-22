using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingTurnActionScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingTurnActionScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nVHVybkFjdGlvblNjUnNwLnByb3RvIkQKHFN3b3Jk" + "VHJhaW5pbmdUdXJuQWN0aW9uU2NSc3ASDwoHcmV0Y29kZRgDIAEoDRITCgtB" + "Q0JJTU9HTktBShgFIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingTurnActionScRsp), SwordTrainingTurnActionScRsp.Parser, new string[2] { "Retcode", "ACBIMOGNKAJ" }, null, null, null, null)
		}));
	}
}
