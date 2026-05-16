using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DMJNAGEKONAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DMJNAGEKONAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFETUpOQUdFS09OQS5wcm90byIeCgtETUpOQUdFS09OQRIPCgdyZXRjb2Rl" + "GAwgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DMJNAGEKONA), DMJNAGEKONA.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
