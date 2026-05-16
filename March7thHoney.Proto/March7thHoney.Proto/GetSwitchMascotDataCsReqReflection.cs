using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetSwitchMascotDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetSwitchMascotDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch5HZXRTd2l0Y2hNYXNjb3REYXRhQ3NSZXEucHJvdG8iLwoYR2V0U3dpdGNo" + "TWFzY290RGF0YUNzUmVxEhMKC0NQTU9PS0ZLQkVHGAMgASgNQhaqAhNNYXJj" + "aDd0aEhvbmV5LlByb3RvYgZwcm90bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetSwitchMascotDataCsReq), GetSwitchMascotDataCsReq.Parser, new string[1] { "CPMOOKFKBEG" }, null, null, null, null)
		}));
	}
}
