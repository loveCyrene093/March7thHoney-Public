using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SwordTrainingResumeGameScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SwordTrainingResumeGameScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiJTd29yZFRyYWluaW5nUmVzdW1lR2FtZVNjUnNwLnByb3RvGhFMTUJIRENG" + "UFBMTC5wcm90byJSChxTd29yZFRyYWluaW5nUmVzdW1lR2FtZVNjUnNwEiEK" + "C0JNS0FFRkFLTkZKGAMgASgLMgwuTE1CSERDRlBQTEwSDwoHcmV0Y29kZRgM" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { LMBHDCFPPLLReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SwordTrainingResumeGameScRsp), SwordTrainingResumeGameScRsp.Parser, new string[2] { "BMKAEFAKNFJ", "Retcode" }, null, null, null, null)
		}));
	}
}
