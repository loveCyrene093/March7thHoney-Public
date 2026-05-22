using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HDEFPBNNMDJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HDEFPBNNMDJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIREVGUEJOTk1ESi5wcm90byIeCgtIREVGUEJOTk1EShIPCgdyZXRjb2Rl" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HDEFPBNNMDJ), HDEFPBNNMDJ.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
