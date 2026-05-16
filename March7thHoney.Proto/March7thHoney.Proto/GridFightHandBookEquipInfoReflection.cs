using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightHandBookEquipInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightHandBookEquipInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiBHcmlkRmlnaHRIYW5kQm9va0VxdWlwSW5mby5wcm90byJPChpHcmlkRmln" + "aHRIYW5kQm9va0VxdWlwSW5mbxIcChRncmlkX2ZpZ2h0X2l0ZW1fbGlzdBgB" + "IAMoDRITCgtOQVBCQUZGQUdCSBgJIAMoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightHandBookEquipInfo), GridFightHandBookEquipInfo.Parser, new string[2] { "GridFightItemList", "NAPBAFFAGBH" }, null, null, null, null)
		}));
	}
}
