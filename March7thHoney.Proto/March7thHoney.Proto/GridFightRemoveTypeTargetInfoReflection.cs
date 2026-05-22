using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRemoveTypeTargetInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRemoveTypeTargetInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNHcmlkRmlnaHRSZW1vdmVUeXBlVGFyZ2V0SW5mby5wcm90byI9Ch1Hcmlk" + "RmlnaHRSZW1vdmVUeXBlVGFyZ2V0SW5mbxIcChRkcmVzc19yb2xlX3VuaXF1" + "ZV9pZBgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRemoveTypeTargetInfo), GridFightRemoveTypeTargetInfo.Parser, new string[1] { "DressRoleUniqueId" }, null, null, null, null)
		}));
	}
}
