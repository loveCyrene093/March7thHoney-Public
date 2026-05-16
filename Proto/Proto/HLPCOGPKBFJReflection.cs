using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLPCOGPKBFJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLPCOGPKBFJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITFBDT0dQS0JGSi5wcm90byIhCgtITFBDT0dQS0JGShISCgphdWdtZW50" + "X2lkGAEgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLPCOGPKBFJ), HLPCOGPKBFJ.Parser, new string[1] { "AugmentId" }, null, null, null, null)
		}));
	}
}
