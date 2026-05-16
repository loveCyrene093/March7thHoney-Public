using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ClientObjUploadCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ClientObjUploadCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpDbGllbnRPYmpVcGxvYWRDc1JlcS5wcm90bxoRTk9GTUhOTklKQU4ucHJv" + "dG8iXwoUQ2xpZW50T2JqVXBsb2FkQ3NSZXESEwoLS0tDRENJSkhKRkEYAiAB" + "KA0SIQoLTUtIRElOREdITUQYCiABKA4yDC5OT0ZNSE5OSUpBThIPCgdzY19k" + "YXRhGAwgASgMQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[1] { NOFMHNNIJANReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ClientObjUploadCsReq), ClientObjUploadCsReq.Parser, new string[3] { "KKCDCIJHJFA", "MKHDINDGHMD", "ScData" }, null, null, null, null)
		}));
	}
}
