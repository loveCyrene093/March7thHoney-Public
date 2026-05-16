using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NPOFLIHNANMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NPOFLIHNANMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOUE9GTElITkFOTS5wcm90byJOCgtOUE9GTElITkFOTRIWCg5jbGllbnRf" + "dGltZV9tcxgBIAEoBBIPCgdyZXRjb2RlGAYgASgNEhYKDnNlcnZlcl90aW1l" + "X21zGAwgASgEQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NPOFLIHNANM), NPOFLIHNANM.Parser, new string[3] { "ClientTimeMs", "Retcode", "ServerTimeMs" }, null, null, null, null)
		}));
	}
}
