using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CNPOHCGPDFPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CNPOHCGPDFPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDTlBPSENHUERGUC5wcm90byJMCgtDTlBPSENHUERGUBITCgtIQ0JFREVD" + "TEFJQxgCIAEoCBITCgtNTERCRE5DQ0pERBgFIAEoDRITCgtDQk9KTktDQkVE" + "SBgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CNPOHCGPDFP), CNPOHCGPDFP.Parser, new string[3] { "HCBEDECLAIC", "MLDBDNCCJDD", "CBOJNKCBEDH" }, null, null, null, null)
		}));
	}
}
