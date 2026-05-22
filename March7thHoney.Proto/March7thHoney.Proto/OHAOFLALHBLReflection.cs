using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OHAOFLALHBLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OHAOFLALHBLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSEFPRkxBTEhCTC5wcm90byI3CgtPSEFPRkxBTEhCTBITCgtKTk9NRElG" + "TkVKSBgCIAEoDRITCgtPTkVCTk9HTE9ORBgEIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OHAOFLALHBL), OHAOFLALHBL.Parser, new string[2] { "JNOMDIFNEJH", "ONEBNOGLOND" }, null, null, null, null)
		}));
	}
}
