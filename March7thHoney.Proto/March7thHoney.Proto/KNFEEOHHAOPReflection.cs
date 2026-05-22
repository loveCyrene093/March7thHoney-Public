using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KNFEEOHHAOPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KNFEEOHHAOPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTkZFRU9ISEFPUC5wcm90byIeCgtLTkZFRU9ISEFPUBIPCgdyZXRjb2Rl" + "GAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KNFEEOHHAOP), KNFEEOHHAOP.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
