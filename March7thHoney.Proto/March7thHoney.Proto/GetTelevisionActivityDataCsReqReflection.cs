using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTelevisionActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTelevisionActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHZXRUZWxldmlzaW9uQWN0aXZpdHlEYXRhQ3NSZXEucHJvdG8iIAoeR2V0" + "VGVsZXZpc2lvbkFjdGl2aXR5RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTelevisionActivityDataCsReq), GetTelevisionActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
