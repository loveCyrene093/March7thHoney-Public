using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAllRedDotDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAllRedDotDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRBbGxSZWREb3REYXRhQ3NSZXEucHJvdG8iFwoVR2V0QWxsUmVkRG90" + "RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAllRedDotDataCsReq), GetAllRedDotDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
