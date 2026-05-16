using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurChallengeCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurChallengeCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRDdXJDaGFsbGVuZ2VDc1JlcS5wcm90byIWChRHZXRDdXJDaGFsbGVu" + "Z2VDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurChallengeCsReq), GetCurChallengeCsReq.Parser, null, null, null, null, null)
		}));
	}
}
