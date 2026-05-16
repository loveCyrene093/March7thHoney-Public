using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class SetLineupNameCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static SetLineupNameCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChhTZXRMaW5ldXBOYW1lQ3NSZXEucHJvdG8iMQoSU2V0TGluZXVwTmFtZUNz" + "UmVxEg0KBWluZGV4GAUgASgNEgwKBG5hbWUYCiABKAlCFqoCE01hcmNoN3Ro" + "SG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(SetLineupNameCsReq), SetLineupNameCsReq.Parser, new string[2] { "Index", "Name" }, null, null, null, null)
		}));
	}
}
