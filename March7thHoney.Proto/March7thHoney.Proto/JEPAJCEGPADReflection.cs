using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JEPAJCEGPADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JEPAJCEGPADReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKRVBBSkNFR1BBRC5wcm90byIeCgtKRVBBSkNFR1BBRBIPCgdyZXRjb2Rl" + "GAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JEPAJCEGPAD), JEPAJCEGPAD.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
