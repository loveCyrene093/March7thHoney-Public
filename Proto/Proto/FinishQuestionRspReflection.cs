using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FinishQuestionRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FinishQuestionRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdGaW5pc2hRdWVzdGlvblJzcC5wcm90byJ4ChFGaW5pc2hRdWVzdGlvblJz" + "cBIPCgdyZXRjb2RlGAUgASgNEhMKC0tPRURDTUlDS05KGAcgASgNEhMKC01M" + "REJETkNDSkREGAsgASgNEhMKC0NCT0pOS0NCRURIGA0gASgNEhMKC09GT0NE" + "SEVQTU9JGA8gASgIQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FinishQuestionRsp), FinishQuestionRsp.Parser, new string[5] { "Retcode", "KOEDCMICKNJ", "MLDBDNCCJDD", "CBOJNKCBEDH", "OFOCDHEPMOI" }, null, null, null, null)
		}));
	}
}
