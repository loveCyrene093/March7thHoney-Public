using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OKILDHPDMIBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OKILDHPDMIBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPS0lMREhQRE1JQi5wcm90byIeCgtPS0lMREhQRE1JQhIPCgdyZXRjb2Rl" + "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OKILDHPDMIB), OKILDHPDMIB.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
