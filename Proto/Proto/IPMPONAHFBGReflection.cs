using System;
using System.Runtime.CompilerServices;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPMPONAHFBGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPMPONAHFBGReflection()
	{
		InlineArray5<string> buffer = default(InlineArray5<string>);
		buffer[0] = "ChFJUE1QT05BSEZCRy5wcm90byKQAQoLSVBNUE9OQUhGQkcSEwoLSkZKSkxH";
		buffer[1] = "RkNPTU8YAiABKA0SGAoQdG90YWxfYXV0b190dXJucxgKIAEoDRITCgtHSEJO";
		buffer[2] = "T0FNT0FORBgLIAEoDRITCgtJRURQQklBQkJDSxgMIAEoDRITCgt0b3RhbF90";
		buffer[3] = "dXJucxgOIAEoDRITCgtIRkxJQUpDTkpQTBgPIAEoDUIWqgITTWFyY2g3dGhI";
		buffer[4] = "b25leS5Qcm90b2IGcHJvdG8z";
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String(string.Concat((ReadOnlySpan<string?>)buffer)), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPMPONAHFBG), IPMPONAHFBG.Parser, new string[6] { "JFJJLGFCOMO", "TotalAutoTurns", "GHBNOAMOAND", "IEDPBIABBCK", "TotalTurns", "HFLIAJCNJPL" }, null, null, null, null)
		}));
	}
}
