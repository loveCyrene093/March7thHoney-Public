using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NNKLGPJAFPJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NNKLGPJAFPJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOTktMR1BKQUZQSi5wcm90byIeCgtOTktMR1BKQUZQShIPCgdyZXRjb2Rl" + "GAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NNKLGPJAFPJ), NNKLGPJAFPJ.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
