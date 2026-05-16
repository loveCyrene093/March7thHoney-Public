using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class RankUpAvatarCsReqReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static RankUpAvatarCsReqReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdSYW5rVXBBdmF0YXJDc1JlcS5wcm90bxoSSXRlbUNvc3REYXRhLnByb3Rv" + "IlYKEVJhbmtVcEF2YXRhckNzUmVxEhEKCWF2YXRhcl9pZBgCIAEoDRIMCgRy" + "YW5rGAMgASgNEiAKCWNvc3RfZGF0YRgEIAEoCzINLkl0ZW1Db3N0RGF0YUIW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { ItemCostDataReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(RankUpAvatarCsReq), RankUpAvatarCsReq.Parser, new string[3] { "AvatarId", "Rank", "CostData" }, null, null, null, null)
		}));
	}
}
