using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetQuestDataCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetQuestDataCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdHZXRRdWVzdERhdGFDc1JlcS5wcm90byITChFHZXRRdWVzdERhdGFDc1Jl" + "cUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetQuestDataCsReq), GetQuestDataCsReq.Parser, null, null, null, null, null)
		}));
	}
}
