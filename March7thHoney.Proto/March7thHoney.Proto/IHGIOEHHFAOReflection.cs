using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IHGIOEHHFAOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IHGIOEHHFAOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJSEdJT0VISEZBTy5wcm90byIeCgtJSEdJT0VISEZBTxIPCgdyZXRjb2Rl" + "GAIgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IHGIOEHHFAO), IHGIOEHHFAO.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
