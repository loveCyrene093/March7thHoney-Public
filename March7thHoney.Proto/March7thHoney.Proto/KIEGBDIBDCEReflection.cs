using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KIEGBDIBDCEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KIEGBDIBDCEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLSUVHQkRJQkRDRS5wcm90byJzCgtLSUVHQkRJQkRDRRIQCghldmVudF9p" + "ZBgHIAEoDRITCgtOTU9FQ0VITkxBQxgKIAEoDRITCgtLT0VEQ01JQ0tOShgL" + "IAEoDRITCgtMUEZES0hESExDRBgMIAMoDRITCgtLRUtBRVBERUpKUBgNIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KIEGBDIBDCE), KIEGBDIBDCE.Parser, new string[5] { "EventId", "NMOECEHNLAC", "KOEDCMICKNJ", "LPFDKHDHLCD", "KEKAEPDEJJP" }, null, null, null, null)
		}));
	}
}
