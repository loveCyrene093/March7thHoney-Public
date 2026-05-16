using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NGPOFGPEDCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NGPOFGPEDCJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOR1BPRkdQRURDSi5wcm90byIeCgtOR1BPRkdQRURDShIPCgdyZXRjb2Rl" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NGPOFGPEDCJ), NGPOFGPEDCJ.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
