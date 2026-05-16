using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CDFGBPOPNALReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CDFGBPOPNALReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDREZHQlBPUE5BTC5wcm90byIzCgtDREZHQlBPUE5BTBIPCgdyZXRjb2Rl" + "GAIgASgNEhMKC0NPT09GRktJRE1DGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CDFGBPOPNAL), CDFGBPOPNAL.Parser, new string[2] { "Retcode", "COOOFFKIDMC" }, null, null, null, null)
		}));
	}
}
