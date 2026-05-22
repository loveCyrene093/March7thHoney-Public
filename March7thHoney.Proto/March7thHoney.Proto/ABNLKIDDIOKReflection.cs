using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ABNLKIDDIOKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ABNLKIDDIOKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQk5MS0lERElPSy5wcm90byIeCgtBQk5MS0lERElPSxIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ABNLKIDDIOK), ABNLKIDDIOK.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
