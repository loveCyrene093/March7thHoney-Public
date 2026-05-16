using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightForgeRoleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightForgeRoleInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHcmlkRmlnaHRGb3JnZVJvbGVJbmZvLnByb3RvIj4KFkdyaWRGaWdodEZv" + "cmdlUm9sZUluZm8SDwoHcm9sZV9pZBgIIAEoDRITCgtHSkZHRkhGRkNQShgO" + "IAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightForgeRoleInfo), GridFightForgeRoleInfo.Parser, new string[2] { "RoleId", "GJFGFHFFCPJ" }, null, null, null, null)
		}));
	}
}
