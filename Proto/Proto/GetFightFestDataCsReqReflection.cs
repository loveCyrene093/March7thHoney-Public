using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFightFestDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFightFestDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChtHZXRGaWdodEZlc3REYXRhQ3NSZXEucHJvdG8iFwoVR2V0RmlnaHRGZXN0" + "RGF0YUNzUmVxQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFightFestDataCsReq), GetFightFestDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
