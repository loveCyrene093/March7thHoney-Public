using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MDGOBJOFODBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MDGOBJOFODBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNREdPQkpPRk9EQi5wcm90byIeCgtNREdPQkpPRk9EQhIPCgdyZXRjb2Rl" + "GAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MDGOBJOFODB), MDGOBJOFODB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
