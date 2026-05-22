using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SelectPhoneCaseScRspReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SelectPhoneCaseScRspReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpTZWxlY3RQaG9uZUNhc2VTY1JzcC5wcm90byJUChRTZWxlY3RQaG9uZUNh" + "c2VTY1JzcBIPCgdyZXRjb2RlGAMgASgNEhMKC0dNSE9FQUJIS0lHGAQgASgN" + "EhYKDmN1cl9waG9uZV9jYXNlGAogASgNQhaqAhNNYXJjaDd0aEhvbmV5LlBy" + "b3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SelectPhoneCaseScRsp), SelectPhoneCaseScRsp.Parser, new string[3] { "Retcode", "GMHOEABHKIG", "CurPhoneCase" }, null, null, null, null)
		}));
	}
}
