using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KIJGIOKOKPFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KIJGIOKOKPFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSUpHSU9LT0tQRi5wcm90byIeCgtLSUpHSU9LT0tQRhIPCgdyZXRjb2Rl" + "GA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KIJGIOKOKPF), KIJGIOKOKPF.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
