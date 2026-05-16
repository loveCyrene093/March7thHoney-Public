using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MFNOEOEDFDFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MFNOEOEDFDFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRk5PRU9FREZERi5wcm90byIeCgtNRk5PRU9FREZERhIPCgdyZXRjb2Rl" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MFNOEOEDFDF), MFNOEOEDFDF.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
