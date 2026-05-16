using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesCollectIncomeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesCollectIncomeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFQbGFuZXRGZXNDb2xsZWN0SW5jb21lQ3NSZXEucHJvdG8iMgobUGxhbmV0" + "RmVzQ29sbGVjdEluY29tZUNzUmVxEhMKC0JIREhJSUJDRElKGAUgASgNQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesCollectIncomeCsReq), PlanetFesCollectIncomeCsReq.Parser, new string[1] { "BHDHIIBCDIJ" }, null, null, null, null)
		}));
	}
}
