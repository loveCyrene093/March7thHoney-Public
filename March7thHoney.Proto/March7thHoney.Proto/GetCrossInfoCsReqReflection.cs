using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCrossInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCrossInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRDcm9zc0luZm9Dc1JlcS5wcm90byITChFHZXRDcm9zc0luZm9Dc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCrossInfoCsReq), GetCrossInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
