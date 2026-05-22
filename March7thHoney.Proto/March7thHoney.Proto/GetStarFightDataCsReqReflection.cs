using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetStarFightDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetStarFightDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRTdGFyRmlnaHREYXRhQ3NSZXEucHJvdG8iFwoVR2V0U3RhckZpZ2h0" + "RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetStarFightDataCsReq), GetStarFightDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
