using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IAGFLEBBOGBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IAGFLEBBOGBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQUdGTEVCQk9HQi5wcm90byIeCgtJQUdGTEVCQk9HQhIPCgdyZXRjb2Rl" + "GA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IAGFLEBBOGB), IAGFLEBBOGB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
