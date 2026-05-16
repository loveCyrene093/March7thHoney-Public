using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightSupplyRoleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightSupplyRoleInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch1HcmlkRmlnaHRTdXBwbHlSb2xlSW5mby5wcm90byJIChdHcmlkRmlnaHRT" + "dXBwbHlSb2xlSW5mbxIcChRncmlkX2ZpZ2h0X2l0ZW1fbGlzdBgCIAMoDRIP" + "Cgdyb2xlX2lkGAMgASgNQhaqAhNNYXJjaDd0aEhvbmV5LlByb3RvYgZwcm90" + "bzM="), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightSupplyRoleInfo), GridFightSupplyRoleInfo.Parser, new string[2] { "GridFightItemList", "RoleId" }, null, null, null, null)
		}));
	}
}
