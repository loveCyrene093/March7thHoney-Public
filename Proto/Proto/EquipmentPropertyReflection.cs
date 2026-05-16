using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EquipmentPropertyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EquipmentPropertyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChdFcXVpcG1lbnRQcm9wZXJ0eS5wcm90byJPChFFcXVpcG1lbnRQcm9wZXJ0" + "eRIKCgJpZBgBIAEoDRIMCgRyYW5rGAIgASgNEhEKCXByb21vdGlvbhgDIAEo" + "DRINCgVsZXZlbBgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJv" + "dG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EquipmentProperty), EquipmentProperty.Parser, new string[4] { "Id", "Rank", "Promotion", "Level" }, null, null, null, null)
		}));
	}
}
