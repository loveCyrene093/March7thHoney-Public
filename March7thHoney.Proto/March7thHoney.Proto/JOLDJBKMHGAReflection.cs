using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JOLDJBKMHGAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JOLDJBKMHGAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKT0xESkJLTUhHQS5wcm90byIeCgtKT0xESkJLTUhHQRIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JOLDJBKMHGA), JOLDJBKMHGA.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
