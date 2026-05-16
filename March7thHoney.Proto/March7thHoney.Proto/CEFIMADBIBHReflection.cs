using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CEFIMADBIBHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CEFIMADBIBHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDRUZJTUFEQklCSC5wcm90byIeCgtDRUZJTUFEQklCSBIPCgdyZXRjb2Rl" + "GAUgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CEFIMADBIBH), CEFIMADBIBH.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
