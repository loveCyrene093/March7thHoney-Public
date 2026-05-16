using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishQuestScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishQuestScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChZGaW5pc2hRdWVzdFNjUnNwLnByb3RvIiMKEEZpbmlzaFF1ZXN0U2NSc3AS" + "DwoHcmV0Y29kZRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishQuestScRsp), FinishQuestScRsp.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
