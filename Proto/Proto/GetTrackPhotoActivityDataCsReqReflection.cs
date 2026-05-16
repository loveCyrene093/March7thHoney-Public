using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetTrackPhotoActivityDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetTrackPhotoActivityDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHZXRUcmFja1Bob3RvQWN0aXZpdHlEYXRhQ3NSZXEucHJvdG8iIAoeR2V0" + "VHJhY2tQaG90b0FjdGl2aXR5RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5" + "LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetTrackPhotoActivityDataCsReq), GetTrackPhotoActivityDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
