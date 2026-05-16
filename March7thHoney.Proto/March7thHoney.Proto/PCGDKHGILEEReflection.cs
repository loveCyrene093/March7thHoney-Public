using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCGDKHGILEEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCGDKHGILEEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ0dES0hHSUxFRS5wcm90byIeCgtQQ0dES0hHSUxFRRIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCGDKHGILEE), PCGDKHGILEE.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
