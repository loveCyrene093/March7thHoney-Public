using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PCPJKOHFECEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PCPJKOHFECEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQQ1BKS09IRkVDRS5wcm90byIzCgtQQ1BKS09IRkVDRRITCgtJT0pLREdD" + "RkNHRxgDIAEoDRIPCgdyZXRjb2RlGAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PCPJKOHFECE), PCPJKOHFECE.Parser, new string[2] { "IOJKDGCFCGG", "Retcode" }, null, null, null, null)
		}));
	}
}
