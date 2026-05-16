using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetAllLineupDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetAllLineupDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRBbGxMaW5ldXBEYXRhQ3NSZXEucHJvdG8iFwoVR2V0QWxsTGluZXVw" + "RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetAllLineupDataCsReq), GetAllLineupDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
