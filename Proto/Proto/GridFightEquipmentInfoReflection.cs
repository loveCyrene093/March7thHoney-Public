using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightEquipmentInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightEquipmentInfoReflection()
	{
		InlineArray8<string> buffer = default(InlineArray8<string>);
		buffer[0] = "ChxHcmlkRmlnaHRFcXVpcG1lbnRJbmZvLnByb3RvIpICChZHcmlkRmlnaHRF";
		buffer[1] = "cXVpcG1lbnRJbmZvElwKHGNvbnZlcnRfcHJvcGVydHlfdG9fZml4cG9pbnQY";
		buffer[2] = "ASADKAsyNi5HcmlkRmlnaHRFcXVpcG1lbnRJbmZvLkNvbnZlcnRQcm9wZXJ0";
		buffer[3] = "eVRvRml4cG9pbnRFbnRyeRIOCgZzb3VyY2UYBiABKA0SHwoXZ3JpZF9maWdo";
		buffer[4] = "dF9lcXVpcG1lbnRfaWQYCCABKA0SEQoJdW5pcXVlX2lkGAsgASgNEhQKDGlz";
		buffer[5] = "X3RlbXBvcmFyeRgMIAEoCBpACh5Db252ZXJ0UHJvcGVydHlUb0ZpeHBvaW50";
		buffer[6] = "RW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFy";
		buffer[7] = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEquipmentInfo), GridFightEquipmentInfo.Parser, new string[5] { "ConvertPropertyToFixpoint", "Source", "GridFightEquipmentId", "UniqueId", "IsTemporary" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
