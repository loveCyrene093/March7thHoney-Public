using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetActivityElationDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetActivityElationDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiFHZXRBY3Rpdml0eUVsYXRpb25EYXRhQ3NSZXEucHJvdG8iHQobR2V0QWN0" + "aXZpdHlFbGF0aW9uRGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3Rv" + "YgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetActivityElationDataCsReq), GetActivityElationDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
