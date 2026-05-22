using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BLKKAGMOJGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BLKKAGMOJGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCTEtLQUdNT0pHUC5wcm90byIzCgtCTEtLQUdNT0pHUBIPCgdyZXRjb2Rl" + "GAggASgNEhMKC0tFUE1KS0dKTE5KGAogASgIQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BLKKAGMOJGP), BLKKAGMOJGP.Parser, new string[2] { "Retcode", "KEPMJKGJLNJ" }, null, null, null, null)
		}));
	}
}
