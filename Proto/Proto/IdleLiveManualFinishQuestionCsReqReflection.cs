using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IdleLiveManualFinishQuestionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IdleLiveManualFinishQuestionCsReqReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "CidJZGxlTGl2ZU1hbnVhbEZpbmlzaFF1ZXN0aW9uQ3NSZXEucHJvdG8idwoh";
		buffer[1] = "SWRsZUxpdmVNYW51YWxGaW5pc2hRdWVzdGlvbkNzUmVxEhMKC0tPRURDTUlD";
		buffer[2] = "S05KGAMgASgNEhMKC09GT0NESEVQTU9JGAcgASgIEhMKC0NCT0pOS0NCRURI";
		buffer[3] = "GAwgASgNEhMKC01MREJETkNDSkREGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5";
		buffer[4] = "LlByb3RvYgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IdleLiveManualFinishQuestionCsReq), IdleLiveManualFinishQuestionCsReq.Parser, new string[4] { "KOEDCMICKNJ", "OFOCDHEPMOI", "CBOJNKCBEDH", "MLDBDNCCJDD" }, null, null, null, null)
		}));
	}
}
