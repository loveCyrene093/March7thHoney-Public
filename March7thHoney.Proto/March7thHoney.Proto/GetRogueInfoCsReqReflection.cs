using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRSb2d1ZUluZm9Dc1JlcS5wcm90byITChFHZXRSb2d1ZUluZm9Dc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueInfoCsReq), GetRogueInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
