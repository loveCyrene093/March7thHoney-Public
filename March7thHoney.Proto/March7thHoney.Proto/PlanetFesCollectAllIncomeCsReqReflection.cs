using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class PlanetFesCollectAllIncomeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static PlanetFesCollectAllIncomeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRQbGFuZXRGZXNDb2xsZWN0QWxsSW5jb21lQ3NSZXEucHJvdG8iIAoeUGxh" + "bmV0RmVzQ29sbGVjdEFsbEluY29tZUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(PlanetFesCollectAllIncomeCsReq), PlanetFesCollectAllIncomeCsReq.Parser, null, null, null, null, null)
		}));
	}
}
