using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MHJOJEFEOKKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MHJOJEFEOKKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSEpPSkVGRU9LSy5wcm90byIeCgtNSEpPSkVGRU9LSxIPCgdyZXRjb2Rl" + "GAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MHJOJEFEOKK), MHJOJEFEOKK.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
