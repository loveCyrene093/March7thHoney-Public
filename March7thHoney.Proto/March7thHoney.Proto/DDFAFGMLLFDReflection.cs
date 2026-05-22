using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DDFAFGMLLFDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DDFAFGMLLFDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEREZBRkdNTExGRC5wcm90byJMCgtEREZBRkdNTExGRBITCgtGS01NTEtO" + "SkNOTxgCIAEoDRITCgtNS05OTUtCRVBPSRgJIAEoDRITCgtBUERBQk5HRE1Q" + "TRgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DDFAFGMLLFD), DDFAFGMLLFD.Parser, new string[3] { "FKMMLKNJCNO", "MKNNMKBEPOI", "APDABNGDMPM" }, null, null, null, null)
		}));
	}
}
