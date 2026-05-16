using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetCurAssistCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetCurAssistCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRDdXJBc3Npc3RDc1JlcS5wcm90byITChFHZXRDdXJBc3Npc3RDc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetCurAssistCsReq), GetCurAssistCsReq.Parser, null, null, null, null, null)
		}));
	}
}
