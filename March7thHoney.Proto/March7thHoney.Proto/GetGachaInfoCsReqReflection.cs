using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetGachaInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetGachaInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRHYWNoYUluZm9Dc1JlcS5wcm90byITChFHZXRHYWNoYUluZm9Dc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetGachaInfoCsReq), GetGachaInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
