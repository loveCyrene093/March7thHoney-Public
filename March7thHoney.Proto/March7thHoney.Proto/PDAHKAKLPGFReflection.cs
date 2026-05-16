using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PDAHKAKLPGFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PDAHKAKLPGFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQREFIS0FLTFBHRi5wcm90byIzCgtQREFIS0FLTFBHRhIPCgdyZXRjb2Rl" + "GAwgASgNEhMKC0hFSkFPT0NIRUZHGA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PDAHKAKLPGF), PDAHKAKLPGF.Parser, new string[2] { "Retcode", "HEJAOOCHEFG" }, null, null, null, null)
		}));
	}
}
