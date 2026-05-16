using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OPOACMLCGAHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OPOACMLCGAHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPUE9BQ01MQ0dBSC5wcm90byJICgtPUE9BQ01MQ0dBSBIPCgdyZXRjb2Rl" + "GAQgASgNEhMKC0xGSU1JSExPTE5CGAYgASgMEhMKC0xBSEFJQUlLUEpOGA8g" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OPOACMLCGAH), OPOACMLCGAH.Parser, new string[3] { "Retcode", "LFIMIHLOLNB", "LAHAIAIKPJN" }, null, null, null, null)
		}));
	}
}
