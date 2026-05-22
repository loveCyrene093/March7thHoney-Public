using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CAOCJIENIEPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CAOCJIENIEPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDQU9DSklFTklFUC5wcm90byI3CgtDQU9DSklFTklFUBITCgtCQ0dDR0hF" + "UERFQRgBIAEoDRITCgtGQU5PTE5PTUhGSRgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CAOCJIENIEP), CAOCJIENIEP.Parser, new string[2] { "BCGCGHEPDEA", "FANOLNOMHFI" }, null, null, null, null)
		}));
	}
}
