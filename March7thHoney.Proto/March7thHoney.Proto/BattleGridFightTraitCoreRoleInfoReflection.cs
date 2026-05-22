using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BattleGridFightTraitCoreRoleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BattleGridFightTraitCoreRoleInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiZCYXR0bGVHcmlkRmlnaHRUcmFpdENvcmVSb2xlSW5mby5wcm90byJGCiBC" + "YXR0bGVHcmlkRmlnaHRUcmFpdENvcmVSb2xlSW5mbxIPCgdyb2xlX2lkGAEg" + "ASgNEhEKCXVuaXF1ZV9pZBgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BattleGridFightTraitCoreRoleInfo), BattleGridFightTraitCoreRoleInfo.Parser, new string[2] { "RoleId", "UniqueId" }, null, null, null, null)
		}));
	}
}
