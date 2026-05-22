using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IFLOGJBONHIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IFLOGJBONHIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRkxPR0pCT05ISS5wcm90byJMCgtJRkxPR0pCT05ISRITCgtNR05HUEdQ" + "UElBQRgBIAEoDRITCgtHSU9QTUJBSkVOSxgCIAMoDRITCgtKS1BHQUNMS0VF" + "QxgDIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IFLOGJBONHI), IFLOGJBONHI.Parser, new string[3] { "MGNGPGPPIAA", "GIOPMBAJENK", "JKPGACLKEEC" }, null, null, null, null)
		}));
	}
}
