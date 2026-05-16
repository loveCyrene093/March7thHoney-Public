using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCNOGENAHJJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCNOGENAHJJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ05PR0VOQUhKSi5wcm90byIeCgtCQ05PR0VOQUhKShIPCgdyZXRjb2Rl" + "GA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCNOGENAHJJ), BCNOGENAHJJ.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
