using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class TeleportToMissionResetPointCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static TeleportToMissionResetPointCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZUZWxlcG9ydFRvTWlzc2lvblJlc2V0UG9pbnRDc1JlcS5wcm90byIiCiBU" + "ZWxlcG9ydFRvTWlzc2lvblJlc2V0UG9pbnRDc1JlcUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(TeleportToMissionResetPointCsReq), TeleportToMissionResetPointCsReq.Parser, null, null, null, null, null)
		}));
	}
}
