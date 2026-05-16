using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CCEHGDPFGINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CCEHGDPFGINReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQ0VIR0RQRkdJTi5wcm90byIeCgtDQ0VIR0RQRkdJThIPCgdyZXRjb2Rl" + "GAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CCEHGDPFGIN), CCEHGDPFGIN.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
