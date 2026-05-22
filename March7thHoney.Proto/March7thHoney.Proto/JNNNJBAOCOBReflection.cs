using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JNNNJBAOCOBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JNNNJBAOCOBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTk5OSkJBT0NPQi5wcm90byIeCgtKTk5OSkJBT0NPQhIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JNNNJBAOCOB), JNNNJBAOCOB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
