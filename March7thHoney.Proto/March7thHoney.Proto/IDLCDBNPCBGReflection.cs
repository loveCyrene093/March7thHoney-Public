using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IDLCDBNPCBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IDLCDBNPCBGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRExDREJOUENCRy5wcm90byIeCgtJRExDREJOUENCRxIPCgdyZXRjb2Rl" + "GAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IDLCDBNPCBG), IDLCDBNPCBG.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
