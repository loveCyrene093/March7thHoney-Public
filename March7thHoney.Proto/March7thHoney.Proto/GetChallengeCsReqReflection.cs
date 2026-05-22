using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetChallengeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetChallengeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRDaGFsbGVuZ2VDc1JlcS5wcm90byITChFHZXRDaGFsbGVuZ2VDc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetChallengeCsReq), GetChallengeCsReq.Parser, null, null, null, null, null)
		}));
	}
}
