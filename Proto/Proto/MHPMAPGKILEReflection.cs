using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MHPMAPGKILEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MHPMAPGKILEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNSFBNQVBHS0lMRS5wcm90byIiCgtNSFBNQVBHS0lMRRITCgtET01HTEhJ" + "S0pFRBgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MHPMAPGKILE), MHPMAPGKILE.Parser, new string[1] { "DOMGLHIKJED" }, null, null, null, null)
		}));
	}
}
