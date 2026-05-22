using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ChenLingQuitStageScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ChenLingQuitStageScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxDaGVuTGluZ1F1aXRTdGFnZVNjUnNwLnByb3RvGhFEQ0VCSklHQVBFSS5w" + "cm90byJMChZDaGVuTGluZ1F1aXRTdGFnZVNjUnNwEiEKC0VES0pNUEFDSE5K" + "GAogASgLMgwuRENFQkpJR0FQRUkSDwoHcmV0Y29kZRgLIAEoDUIWqgITTWFy" + "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { DCEBJIGAPEIReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ChenLingQuitStageScRsp), ChenLingQuitStageScRsp.Parser, new string[2] { "EDKJMPACHNJ", "Retcode" }, null, null, null, null)
		}));
	}
}
