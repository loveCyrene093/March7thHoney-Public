using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KCEBIOHPFBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KCEBIOHPFBPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLQ0VCSU9IUEZCUC5wcm90byJMCgtLQ0VCSU9IUEZCUBITCgtBTk9BTU9M" + "UEdHSxgJIAEoDRITCgtETk5IQ05DS0pDTRgKIAEoAxITCgtGSElNTE1MS0ZK" + "SxgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KCEBIOHPFBP), KCEBIOHPFBP.Parser, new string[3] { "ANOAMOLPGGK", "DNNHCNCKJCM", "FHIMLMLKFJK" }, null, null, null, null)
		}));
	}
}
