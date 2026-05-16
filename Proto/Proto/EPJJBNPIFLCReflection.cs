using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPJJBNPIFLCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPJJBNPIFLCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUEpKQk5QSUZMQy5wcm90byIeCgtFUEpKQk5QSUZMQxIPCgdyZXRjb2Rl" + "GAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPJJBNPIFLC), EPJJBNPIFLC.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
