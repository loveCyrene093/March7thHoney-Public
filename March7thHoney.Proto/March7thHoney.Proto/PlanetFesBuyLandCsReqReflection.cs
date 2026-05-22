using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesBuyLandCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesBuyLandCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtQbGFuZXRGZXNCdXlMYW5kQ3NSZXEucHJvdG8iLAoVUGxhbmV0RmVzQnV5" + "TGFuZENzUmVxEhMKC0JIREhJSUJDRElKGA4gASgNQhaqAhNNYXJjaDd0aEhv" + "bmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesBuyLandCsReq), PlanetFesBuyLandCsReq.Parser, new string[1] { "BHDHIIBCDIJ" }, null, null, null, null)
		}));
	}
}
