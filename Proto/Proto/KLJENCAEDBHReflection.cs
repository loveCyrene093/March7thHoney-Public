using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KLJENCAEDBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KLJENCAEDBHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLTEpFTkNBRURCSC5wcm90byIeCgtLTEpFTkNBRURCSBIPCgdyZXRjb2Rl" + "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KLJENCAEDBH), KLJENCAEDBH.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
