using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OGACFIPDECDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OGACFIPDECDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPR0FDRklQREVDRC5wcm90byJMCgtPR0FDRklQREVDRBITCgtKTU5PUExN" + "SEpMRRgFIAMoDRITCgtBTEpJQkNDREhQShgGIAEoAxITCgtPRE1CSk9ITEFE" + "RxgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OGACFIPDECD), OGACFIPDECD.Parser, new string[3] { "JMNOPLMHJLE", "ALJIBCCDHPJ", "ODMBJOHLADG" }, null, null, null, null)
		}));
	}
}
