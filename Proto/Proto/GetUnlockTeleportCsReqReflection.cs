using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetUnlockTeleportCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetUnlockTeleportCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHZXRVbmxvY2tUZWxlcG9ydENzUmVxLnByb3RvIi8KFkdldFVubG9ja1Rl" + "bGVwb3J0Q3NSZXESFQoNZW50cnlfaWRfbGlzdBgPIAMoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetUnlockTeleportCsReq), GetUnlockTeleportCsReq.Parser, new string[1] { "EntryIdList" }, null, null, null, null)
		}));
	}
}
