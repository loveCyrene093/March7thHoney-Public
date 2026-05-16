using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EJEAJOAAEMBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EJEAJOAAEMBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFSkVBSk9BQUVNQi5wcm90byIeCgtFSkVBSk9BQUVNQhIPCgdyZXRjb2Rl" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EJEAJOAAEMB), EJEAJOAAEMB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
