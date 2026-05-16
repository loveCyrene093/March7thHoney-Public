using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OOCCLBMLECEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OOCCLBMLECEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPT0NDTEJNTEVDRS5wcm90byI3CgtPT0NDTEJNTEVDRRITCgtMRklERFBE" + "UE5JRRgHIAEoCBITCgtBUEVCQ0RES0dPRxgIIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OOCCLBMLECE), OOCCLBMLECE.Parser, new string[2] { "LFIDDPDPNIE", "APEBCDDKGOG" }, null, null, null, null)
		}));
	}
}
