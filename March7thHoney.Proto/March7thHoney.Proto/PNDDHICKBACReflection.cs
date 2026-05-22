using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PNDDHICKBACReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PNDDHICKBACReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTkRESElDS0JBQy5wcm90byIeCgtQTkRESElDS0JBQxIPCgdyZXRjb2Rl" + "GAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PNDDHICKBAC), PNDDHICKBAC.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
