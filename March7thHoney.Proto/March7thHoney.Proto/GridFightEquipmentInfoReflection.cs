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
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 0) = "ChxHcmlkRmlnaHRFcXVpcG1lbnRJbmZvLnByb3RvIpICChZHcmlkRmlnaHRF";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 1) = "cXVpcG1lbnRJbmZvElwKHGNvbnZlcnRfcHJvcGVydHlfdG9fZml4cG9pbnQY";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 2) = "ASADKAsyNi5HcmlkRmlnaHRFcXVpcG1lbnRJbmZvLkNvbnZlcnRQcm9wZXJ0";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 3) = "eVRvRml4cG9pbnRFbnRyeRIOCgZzb3VyY2UYBiABKA0SHwoXZ3JpZF9maWdo";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 4) = "dF9lcXVpcG1lbnRfaWQYCCABKA0SEQoJdW5pcXVlX2lkGAsgASgNEhQKDGlz";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 5) = "X3RlbXBvcmFyeRgMIAEoCBpACh5Db252ZXJ0UHJvcGVydHlUb0ZpeHBvaW50";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 6) = "RW50cnkSCwoDa2V5GAEgASgNEg0KBXZhbHVlGAIgASgNOgI4AUIWqgITTWFy";
		global::_003CPrivateImplementationDetails_003E.InlineArrayElementRef<InlineArray8<string>, string>(ref buffer, 7) = "Y2g3dGhIb25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat(global::_003CPrivateImplementationDetails_003E.InlineArrayAsReadOnlySpan<InlineArray8<string>, string>(in buffer, 8))), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightEquipmentInfo), GridFightEquipmentInfo.Parser, new string[5] { "ConvertPropertyToFixpoint", "Source", "GridFightEquipmentId", "UniqueId", "IsTemporary" }, null, null, null, new GeneratedClrTypeInfo[1])
		}));
	}
}
