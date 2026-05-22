using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NFIKPFBPOMFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NFIKPFBPOMFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORklLUEZCUE9NRi5wcm90byJMCgtORklLUEZCUE9NRhITCgtBQ0NMQkFH" + "S0dFTBgBIAEoDRITCgtLRURBRUFCTEdBQhgCIAEoDRITCgtFQ0lKRUtKQU1Q" + "SxgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NFIKPFBPOMF), NFIKPFBPOMF.Parser, new string[3] { "ACCLBAGKGEL", "KEDAEABLGAB", "ECIJEKJAMPK" }, null, null, null, null)
		}));
	}
}
