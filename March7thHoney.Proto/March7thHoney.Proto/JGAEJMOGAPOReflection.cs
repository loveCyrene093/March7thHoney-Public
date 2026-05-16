using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JGAEJMOGAPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JGAEJMOGAPOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKR0FFSk1PR0FQTy5wcm90byIzCgtKR0FFSk1PR0FQTxIPCgdyZXRjb2Rl" + "GAcgASgNEhMKC0hJT0ZNUEhDUEpQGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JGAEJMOGAPO), JGAEJMOGAPO.Parser, new string[2] { "Retcode", "HIOFMPHCPJP" }, null, null, null, null)
		}));
	}
}
