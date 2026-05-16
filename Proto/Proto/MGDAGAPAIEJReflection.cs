using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MGDAGAPAIEJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MGDAGAPAIEJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNR0RBR0FQQUlFSi5wcm90byIeCgtNR0RBR0FQQUlFShIPCgdyZXRjb2Rl" + "GAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MGDAGAPAIEJ), MGDAGAPAIEJ.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
