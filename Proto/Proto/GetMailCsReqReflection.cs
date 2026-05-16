using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetMailCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetMailCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChJHZXRNYWlsQ3NSZXEucHJvdG8iOAoMR2V0TWFpbENzUmVxEhMKC0ZIR0tM" + "SkVISUdBGAEgASgNEhMKC0RETFBHTkhBRENKGAYgASgNQhaqAhNNYXJjaDd0" + "aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetMailCsReq), GetMailCsReq.Parser, new string[2] { "FHGKLJEHIGA", "DDLPGNHADCJ" }, null, null, null, null)
		}));
	}
}
