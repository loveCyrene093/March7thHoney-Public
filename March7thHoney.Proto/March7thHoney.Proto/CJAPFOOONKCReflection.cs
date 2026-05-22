using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CJAPFOOONKCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CJAPFOOONKCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDSkFQRk9PT05LQy5wcm90byIzCgtDSkFQRk9PT05LQxITCgtPT0NQQkpM" + "QlBESBgHIAEoDRIPCgdyZXRjb2RlGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CJAPFOOONKC), CJAPFOOONKC.Parser, new string[2] { "OOCPBJLBPDH", "Retcode" }, null, null, null, null)
		}));
	}
}
