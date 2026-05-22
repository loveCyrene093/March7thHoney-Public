using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IEIGLIEIJANReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IEIGLIEIJANReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRUlHTElFSUpBTi5wcm90byIeCgtJRUlHTElFSUpBThIPCgdyZXRjb2Rl" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IEIGLIEIJAN), IEIGLIEIJAN.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
