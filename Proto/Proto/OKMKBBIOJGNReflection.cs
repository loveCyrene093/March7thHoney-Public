using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OKMKBBIOJGNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OKMKBBIOJGNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPS01LQkJJT0pHTi5wcm90byIeCgtPS01LQkJJT0pHThIPCgdyZXRjb2Rl" + "GA0gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OKMKBBIOJGN), OKMKBBIOJGN.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
