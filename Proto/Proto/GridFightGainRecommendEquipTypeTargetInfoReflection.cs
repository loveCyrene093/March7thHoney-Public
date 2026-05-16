using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightGainRecommendEquipTypeTargetInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightGainRecommendEquipTypeTargetInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ci9HcmlkRmlnaHRHYWluUmVjb21tZW5kRXF1aXBUeXBlVGFyZ2V0SW5mby5w" + "cm90byJJCilHcmlkRmlnaHRHYWluUmVjb21tZW5kRXF1aXBUeXBlVGFyZ2V0" + "SW5mbxIcChRkcmVzc19yb2xlX3VuaXF1ZV9pZBgPIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightGainRecommendEquipTypeTargetInfo), GridFightGainRecommendEquipTypeTargetInfo.Parser, new string[1] { "DressRoleUniqueId" }, null, null, null, null)
		}));
	}
}
