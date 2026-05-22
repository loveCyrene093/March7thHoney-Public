using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetShareDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetShareDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRTaGFyZURhdGFDc1JlcS5wcm90byITChFHZXRTaGFyZURhdGFDc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetShareDataCsReq), GetShareDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
