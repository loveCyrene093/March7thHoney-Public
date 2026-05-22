using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JGLMANJEMJAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JGLMANJEMJAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKR0xNQU5KRU1KQS5wcm90byJICgtKR0xNQU5KRU1KQRIPCgdyZXRjb2Rl" + "GAMgASgNEhMKC09QR0RDQkRCS0JPGAogASgNEhMKC0RDUEtQTkxLR01NGA4g" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JGLMANJEMJA), JGLMANJEMJA.Parser, new string[3] { "Retcode", "OPGDCBDBKBO", "DCPKPNLKGMM" }, null, null, null, null)
		}));
	}
}
