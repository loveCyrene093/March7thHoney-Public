using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FLNKHEMBJOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FLNKHEMBJOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGTE5LSEVNQkpPRy5wcm90byIeCgtGTE5LSEVNQkpPRxIPCgdyZXRjb2Rl" + "GAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FLNKHEMBJOG), FLNKHEMBJOG.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
