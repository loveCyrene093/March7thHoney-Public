using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AKHODIIOGDJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AKHODIIOGDJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBS0hPRElJT0dESi5wcm90byIeCgtBS0hPRElJT0dEShIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AKHODIIOGDJ), AKHODIIOGDJ.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
