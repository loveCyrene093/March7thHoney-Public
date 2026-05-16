using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class INDKHMAOAKMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static INDKHMAOAKMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTkRLSE1BT0FLTS5wcm90byIzCgtJTkRLSE1BT0FLTRIPCgdyZXRjb2Rl" + "GAggASgNEhMKC0pMTUpGRUROQk1GGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(INDKHMAOAKM), INDKHMAOAKM.Parser, new string[2] { "Retcode", "JLMJFEDNBMF" }, null, null, null, null)
		}));
	}
}
