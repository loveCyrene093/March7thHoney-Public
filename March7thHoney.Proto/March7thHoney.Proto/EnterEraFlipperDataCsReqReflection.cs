using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EnterEraFlipperDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EnterEraFlipperDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5FbnRlckVyYUZsaXBwZXJEYXRhQ3NSZXEucHJvdG8iPgoYRW50ZXJFcmFG" + "bGlwcGVyRGF0YUNzUmVxEhMKC0pIRExOQlBORUtHGAUgASgNEg0KBXN0YXRl" + "GAYgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EnterEraFlipperDataCsReq), EnterEraFlipperDataCsReq.Parser, new string[2] { "JHDLNBPNEKG", "State" }, null, null, null, null)
		}));
	}
}
