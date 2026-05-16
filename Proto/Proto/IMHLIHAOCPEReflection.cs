using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IMHLIHAOCPEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IMHLIHAOCPEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTUhMSUhBT0NQRS5wcm90byIeCgtJTUhMSUhBT0NQRRIPCgdyZXRjb2Rl" + "GAsgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IMHLIHAOCPE), IMHLIHAOCPE.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
