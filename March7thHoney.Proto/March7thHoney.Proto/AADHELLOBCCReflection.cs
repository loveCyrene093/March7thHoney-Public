using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AADHELLOBCCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AADHELLOBCCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBQURIRUxMT0JDQy5wcm90byIeCgtBQURIRUxMT0JDQxIPCgdyZXRjb2Rl" + "GA4gASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AADHELLOBCC), AADHELLOBCC.Parser, new string[1] { "Retcode" }, null, null, null, null)
		}));
	}
}
