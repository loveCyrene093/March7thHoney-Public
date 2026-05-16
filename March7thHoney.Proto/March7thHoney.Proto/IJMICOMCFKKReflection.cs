using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IJMICOMCFKKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IJMICOMCFKKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSk1JQ09NQ0ZLSy5wcm90byIeCgtJSk1JQ09NQ0ZLSxIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IJMICOMCFKK), IJMICOMCFKK.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
