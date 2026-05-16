using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GetLevelRewardCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GetLevelRewardCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChlHZXRMZXZlbFJld2FyZENzUmVxLnByb3RvIkcKE0dldExldmVsUmV3YXJk" + "Q3NSZXESDQoFbGV2ZWwYByABKA0SIQoZaW50ZXJhY3RlZF9wcm9wX2VudGl0" + "eV9pZBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GetLevelRewardCsReq), GetLevelRewardCsReq.Parser, new string[2] { "Level", "InteractedPropEntityId" }, null, null, null, null)
		}));
	}
}
