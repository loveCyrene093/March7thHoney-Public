using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LAJEEAENKDIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LAJEEAENKDIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQUpFRUFFTktESS5wcm90byIeCgtMQUpFRUFFTktESRIPCgdyZXRjb2Rl" + "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LAJEEAENKDI), LAJEEAENKDI.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
