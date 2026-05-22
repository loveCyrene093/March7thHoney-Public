using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EAAHNDOHPPHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EAAHNDOHPPHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFQUFITkRPSFBQSC5wcm90byIeCgtFQUFITkRPSFBQSBIPCgdyZXRjb2Rl" + "GAcgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EAAHNDOHPPH), EAAHNDOHPPH.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
