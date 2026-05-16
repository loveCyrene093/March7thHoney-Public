using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OKOHEGIBCCGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OKOHEGIBCCGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPS09IRUdJQkNDRy5wcm90byIeCgtPS09IRUdJQkNDRxIPCgdyZXRjb2Rl" + "GAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OKOHEGIBCCG), OKOHEGIBCCG.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
