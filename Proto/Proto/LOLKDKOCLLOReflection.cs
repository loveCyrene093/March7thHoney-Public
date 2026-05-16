using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LOLKDKOCLLOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LOLKDKOCLLOReflection()
	{
		InlineArray6<string> buffer = default(InlineArray6<string>);
		buffer[0] = "ChFMT0xLREtPQ0xMTy5wcm90bxoRTUtFSU5MRk9BRUEucHJvdG8ioAEKC0xP";
		buffer[1] = "TEtES09DTExPEiEKC0pKR0xCUEdOSk1MGAEgASgLMgwuTUtFSU5MRk9BRUES";
		buffer[2] = "IQoLTktGTkVHSURLTksYAiABKAsyDC5NS0VJTkxGT0FFQRIhCgtHQk1CQkxO";
		buffer[3] = "RUdDSRgDIAEoCzIMLk1LRUlOTEZPQUVBEhMKC0JPTUVHSEdOSUtGGAQgASgN";
		buffer[4] = "EhMKC0hDQkdMSkhBR0FFGAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv";
		buffer[5] = "YgZwcm90bzM=";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[1] { MKEINLFOAEAReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LOLKDKOCLLO), LOLKDKOCLLO.Parser, new string[5] { "JJGLBPGNJML", "NKFNEGIDKNK", "GBMBBLNEGCI", "BOMEGHGNIKF", "HCBGLJHAGAE" }, null, null, null, null)
		}));
	}
}
