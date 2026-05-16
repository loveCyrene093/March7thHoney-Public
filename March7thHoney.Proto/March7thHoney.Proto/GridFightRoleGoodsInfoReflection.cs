using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightRoleGoodsInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightRoleGoodsInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChxHcmlkRmlnaHRSb2xlR29vZHNJbmZvLnByb3RvIjwKFkdyaWRGaWdodFJv" + "bGVHb29kc0luZm8SEQoJcm9sZV9zdGFyGAYgASgNEg8KB3JvbGVfaWQYDiAB" + "KA1CFqoCE01hcmNoN3RoSG9uZXkuUHJvdG9iBnByb3RvMw=="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightRoleGoodsInfo), GridFightRoleGoodsInfo.Parser, new string[2] { "RoleStar", "RoleId" }, null, null, null, null)
		}));
	}
}
