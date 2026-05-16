using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetBasicInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetBasicInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRCYXNpY0luZm9Dc1JlcS5wcm90byITChFHZXRCYXNpY0luZm9Dc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetBasicInfoCsReq), GetBasicInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
