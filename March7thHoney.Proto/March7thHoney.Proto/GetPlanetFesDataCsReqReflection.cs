using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPlanetFesDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPlanetFesDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRQbGFuZXRGZXNEYXRhQ3NSZXEucHJvdG8iFwoVR2V0UGxhbmV0RmVz" + "RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPlanetFesDataCsReq), GetPlanetFesDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
