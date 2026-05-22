using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightForgeRoleActionResultReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightForgeRoleActionResultReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiRHcmlkRmlnaHRGb3JnZVJvbGVBY3Rpb25SZXN1bHQucHJvdG8iPAoeR3Jp" + "ZEZpZ2h0Rm9yZ2VSb2xlQWN0aW9uUmVzdWx0EhoKEmZvcmdlX3RhcmdldF9p" + "bmRleBgJIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightForgeRoleActionResult), GridFightForgeRoleActionResult.Parser, new string[1] { "ForgeTargetIndex" }, null, null, null, null)
		}));
	}
}
