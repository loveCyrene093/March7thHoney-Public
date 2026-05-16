using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PPIDKCGHLOOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PPIDKCGHLOOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQUElES0NHSExPTy5wcm90byJICgtQUElES0NHSExPTxIPCgdyZXRjb2Rl" + "GAMgASgNEhMKC0lFUFBGS0dCRkVQGAcgASgNEhMKC09MT05DTk9MTkhOGAgg" + "ASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PPIDKCGHLOO), PPIDKCGHLOO.Parser, new string[3] { "Retcode", "IEPPFKGBFEP", "OLONCNOLNHN" }, null, null, null, null)
		}));
	}
}
