using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MEKCPJMGCOCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MEKCPJMGCOCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNRUtDUEpNR0NPQy5wcm90byJvCgtNRUtDUEpNR0NPQxIQCghncm91cF9p" + "ZBgCIAEoDRITCgtOSEdIRUJKQ0NDTxgEIAEoDRITCgtDT09PRkZLSURNQxgF" + "IAEoDRIPCgdyZXRjb2RlGAYgASgNEhMKC0pDQ09PQUVQR0VEGAwgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MEKCPJMGCOC), MEKCPJMGCOC.Parser, new string[5] { "GroupId", "NHGHEBJCCCO", "COOOFFKIDMC", "Retcode", "JCCOOAEPGED" }, null, null, null, null)
		}));
	}
}
