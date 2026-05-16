using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NFDLLEPHLHNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NFDLLEPHLHNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORkRMTEVQSExITi5wcm90byIzCgtORkRMTEVQSExIThIPCgdyZXRjb2Rl" + "GAYgASgNEhMKC0lNQ0lLTkhIRUhDGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NFDLLEPHLHN), NFDLLEPHLHN.Parser, new string[2] { "Retcode", "IMCIKNHHEHC" }, null, null, null, null)
		}));
	}
}
