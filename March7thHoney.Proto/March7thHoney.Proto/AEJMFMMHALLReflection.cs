using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AEJMFMMHALLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AEJMFMMHALLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRUpNRk1NSEFMTC5wcm90byIzCgtBRUpNRk1NSEFMTBIPCgdyZXRjb2Rl" + "GAIgASgNEhMKC1BIRExNTEhLSUhIGAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AEJMFMMHALL), AEJMFMMHALL.Parser, new string[2] { "Retcode", "PHDLMLHKIHH" }, null, null, null, null)
		}));
	}
}
