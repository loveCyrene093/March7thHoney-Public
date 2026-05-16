using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleLogReportScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleLogReportScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpCYXR0bGVMb2dSZXBvcnRTY1JzcC5wcm90byI8ChRCYXR0bGVMb2dSZXBv" + "cnRTY1JzcBITCgtNSVBNQkdHS0NGTRgBIAEoCBIPCgdyZXRjb2RlGA8gASgN" + "QhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleLogReportScRsp), BattleLogReportScRsp.Parser, new string[2] { "MIPMBGGKCFM", "Retcode" }, null, null, null, null)
		}));
	}
}
