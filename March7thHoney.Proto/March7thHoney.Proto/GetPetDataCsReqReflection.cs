using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetPetDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetPetDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChVHZXRQZXREYXRhQ3NSZXEucHJvdG8iEQoPR2V0UGV0RGF0YUNzUmVxQhaq" + "AhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetPetDataCsReq), GetPetDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
