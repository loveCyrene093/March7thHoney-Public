using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishPlotCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishPlotCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVGaW5pc2hQbG90Q3NSZXEucHJvdG8iJgoPRmluaXNoUGxvdENzUmVxEhMK" + "C0hBSUlCR0NLUERKGAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZw" + "cm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishPlotCsReq), FinishPlotCsReq.Parser, new string[1] { "HAIIBGCKPDJ" }, null, null, null, null)
		}));
	}
}
