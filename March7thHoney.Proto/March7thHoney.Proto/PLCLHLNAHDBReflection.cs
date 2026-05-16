using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PLCLHLNAHDBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PLCLHLNAHDBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQTENMSExOQUhEQi5wcm90byIeCgtQTENMSExOQUhEQhIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PLCLHLNAHDB), PLCLHLNAHDB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
