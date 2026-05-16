using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EEBMIAFNJMCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EEBMIAFNJMCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFRUJNSUFGTkpNQy5wcm90byIeCgtFRUJNSUFGTkpNQxIPCgdyZXRjb2Rl" + "GAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EEBMIAFNJMC), EEBMIAFNJMC.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
