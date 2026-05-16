using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLoginActivityCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLoginActivityCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRMb2dpbkFjdGl2aXR5Q3NSZXEucHJvdG8iFwoVR2V0TG9naW5BY3Rp" + "dml0eUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLoginActivityCsReq), GetLoginActivityCsReq.Parser, null, null, null, null, null)
		}));
	}
}
