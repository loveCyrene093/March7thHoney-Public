using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FIMNIFPFHKDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FIMNIFPFHKDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGSU1OSUZQRkhLRC5wcm90byIeCgtGSU1OSUZQRkhLRBIPCgdyZXRjb2Rl" + "GAkgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FIMNIFPFHKD), FIMNIFPFHKD.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
