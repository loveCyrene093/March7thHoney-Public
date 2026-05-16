using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BEDFGPIFGEDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BEDFGPIFGEDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCRURGR1BJRkdFRC5wcm90byIzCgtCRURGR1BJRkdFRBIPCgdyZXRjb2Rl" + "GAIgASgNEhMKC05ORkFNT0pBSENIGAQgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BEDFGPIFGED), BEDFGPIFGED.Parser, new string[2] { "Retcode", "NNFAMOJAHCH" }, null, null, null, null)
		}));
	}
}
