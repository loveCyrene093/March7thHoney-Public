using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JKPKDPHIPHDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JKPKDPHIPHDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKS1BLRFBISVBIRC5wcm90byIzCgtKS1BLRFBISVBIRBIPCgdyZXRjb2Rl" + "GAMgASgNEhMKC0hFSkFPT0NIRUZHGA8gASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JKPKDPHIPHD), JKPKDPHIPHD.Parser, new string[2] { "Retcode", "HEJAOOCHEFG" }, null, null, null, null)
		}));
	}
}
