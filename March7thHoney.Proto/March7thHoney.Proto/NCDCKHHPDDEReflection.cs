using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NCDCKHHPDDEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NCDCKHHPDDEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQ0RDS0hIUERERS5wcm90byJMCgtOQ0RDS0hIUERERRITCgtNR0hIQ09F" + "SURIRRgEIAEoDRITCgtKRkFOTkdKRUVFQxgFIAEoDRITCgtFRElHRk5GUEJL" + "QRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NCDCKHHPDDE), NCDCKHHPDDE.Parser, new string[3] { "MGHHCOEIDHE", "JFANNGJEEEC", "EDIGFNFPBKA" }, null, null, null, null)
		}));
	}
}
