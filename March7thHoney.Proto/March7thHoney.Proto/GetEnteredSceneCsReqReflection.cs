using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetEnteredSceneCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetEnteredSceneCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChpHZXRFbnRlcmVkU2NlbmVDc1JlcS5wcm90byIWChRHZXRFbnRlcmVkU2Nl" + "bmVDc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetEnteredSceneCsReq), GetEnteredSceneCsReq.Parser, null, null, null, null, null)
		}));
	}
}
