using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FECCGGMMBMKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FECCGGMMBMKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRUNDR0dNTUJNSy5wcm90byJICgtGRUNDR0dNTUJNSxITCgtMTEtPRk5E" + "QUtIRxgBIAEoDRIPCgdyZXRjb2RlGAIgASgNEhMKC0NES0VERlBFRklKGAwg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FECCGGMMBMK), FECCGGMMBMK.Parser, new string[3] { "LLKOFNDAKHG", "Retcode", "CDKEDFPEFIJ" }, null, null, null, null)
		}));
	}
}
