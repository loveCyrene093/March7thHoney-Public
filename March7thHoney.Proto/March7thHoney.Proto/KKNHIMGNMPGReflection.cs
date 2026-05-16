using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KKNHIMGNMPGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KKNHIMGNMPGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLS05ISU1HTk1QRy5wcm90byI3CgtLS05ISU1HTk1QRxITCgtQRkRLS0ZQ" + "UEFBQRgBIAMoDRITCgtDQ09BS0xLQlBNRhgCIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KKNHIMGNMPG), KKNHIMGNMPG.Parser, new string[2] { "PFDKKFPPAAA", "CCOAKLKBPMF" }, null, null, null, null)
		}));
	}
}
