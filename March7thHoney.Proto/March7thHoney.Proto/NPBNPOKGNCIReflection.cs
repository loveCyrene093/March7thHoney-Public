using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NPBNPOKGNCIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NPBNPOKGNCIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOUEJOUE9LR05DSS5wcm90byIeCgtOUEJOUE9LR05DSRIPCgdyZXRjb2Rl" + "GAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NPBNPOKGNCI), NPBNPOKGNCI.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
