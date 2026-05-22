using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRndOptionCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRndOptionCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRSbmRPcHRpb25Dc1JlcS5wcm90byIfChFHZXRSbmRPcHRpb25Dc1Jl" + "cRIKCgJpZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRndOptionCsReq), GetRndOptionCsReq.Parser, new string[1] { "Id" }, null, null, null, null)
		}));
	}
}
