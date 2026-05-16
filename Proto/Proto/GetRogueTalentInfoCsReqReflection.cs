using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetRogueTalentInfoCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetRogueTalentInfoCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HZXRSb2d1ZVRhbGVudEluZm9Dc1JlcS5wcm90byIZChdHZXRSb2d1ZVRh" + "bGVudEluZm9Dc1JlcUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetRogueTalentInfoCsReq), GetRogueTalentInfoCsReq.Parser, null, null, null, null, null)
		}));
	}
}
