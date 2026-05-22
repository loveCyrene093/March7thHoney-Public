using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPCKGLOHJLHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPCKGLOHJLHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUENLR0xPSEpMSC5wcm90byIeCgtJUENLR0xPSEpMSBIPCgdyZXRjb2Rl" + "GAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPCKGLOHJLH), IPCKGLOHJLH.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
