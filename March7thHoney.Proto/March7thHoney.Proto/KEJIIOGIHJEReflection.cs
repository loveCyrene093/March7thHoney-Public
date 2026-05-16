using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KEJIIOGIHJEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KEJIIOGIHJEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRUpJSU9HSUhKRS5wcm90byIeCgtLRUpJSU9HSUhKRRIPCgdyZXRjb2Rl" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KEJIIOGIHJE), KEJIIOGIHJE.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
