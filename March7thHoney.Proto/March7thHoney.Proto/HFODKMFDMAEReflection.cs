using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HFODKMFDMAEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HFODKMFDMAEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIRk9ES01GRE1BRS5wcm90byIeCgtIRk9ES01GRE1BRRIPCgdyZXRjb2Rl" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HFODKMFDMAE), HFODKMFDMAE.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
