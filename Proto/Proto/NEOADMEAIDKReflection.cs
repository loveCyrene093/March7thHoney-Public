using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NEOADMEAIDKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NEOADMEAIDKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORU9BRE1FQUlESy5wcm90byIzCgtORU9BRE1FQUlESxIPCgdyZXRjb2Rl" + "GAIgASgNEhMKC0dHQUxNQ0pOQ05NGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NEOADMEAIDK), NEOADMEAIDK.Parser, new string[2] { "Retcode", "GGALMCJNCNM" }, null, null, null, null)
		}));
	}
}
