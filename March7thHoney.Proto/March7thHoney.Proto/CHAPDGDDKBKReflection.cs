using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CHAPDGDDKBKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CHAPDGDDKBKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSEFQREdEREtCSy5wcm90byIeCgtDSEFQREdEREtCSxIPCgdyZXRjb2Rl" + "GAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CHAPDGDDKBK), CHAPDGDDKBK.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
