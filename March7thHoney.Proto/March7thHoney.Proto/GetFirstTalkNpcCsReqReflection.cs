using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetFirstTalkNpcCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetFirstTalkNpcCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRGaXJzdFRhbGtOcGNDc1JlcS5wcm90byIrChRHZXRGaXJzdFRhbGtO" + "cGNDc1JlcRITCgtucGNfaWRfbGlzdBgEIAMoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetFirstTalkNpcCsReq), GetFirstTalkNpcCsReq.Parser, new string[1] { "NpcIdList" }, null, null, null, null)
		}));
	}
}
