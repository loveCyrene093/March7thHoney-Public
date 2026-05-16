using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterSwordTrainingExamScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterSwordTrainingExamScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFFbnRlclN3b3JkVHJhaW5pbmdFeGFtU2NSc3AucHJvdG8aFVNjZW5lQmF0" + "dGxlSW5mby5wcm90byJVChtFbnRlclN3b3JkVHJhaW5pbmdFeGFtU2NSc3AS" + "DwoHcmV0Y29kZRgMIAEoDRIlCgtiYXR0bGVfaW5mbxgPIAEoCzIQLlNjZW5l" + "QmF0dGxlSW5mb0IWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { SceneBattleInfoReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterSwordTrainingExamScRsp), EnterSwordTrainingExamScRsp.Parser, new string[2] { "Retcode", "BattleInfo" }, null, null, null, null)
		}));
	}
}
