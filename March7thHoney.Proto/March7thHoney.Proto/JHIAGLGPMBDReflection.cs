using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JHIAGLGPMBDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JHIAGLGPMBDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKSElBR0xHUE1CRC5wcm90byIzCgtKSElBR0xHUE1CRBIPCgdyZXRjb2Rl" + "GAUgASgNEhMKC0JGQklJUE1CRkhGGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JHIAGLGPMBD), JHIAGLGPMBD.Parser, new string[2] { "Retcode", "BFBIIPMBFHF" }, null, null, null, null)
		}));
	}
}
