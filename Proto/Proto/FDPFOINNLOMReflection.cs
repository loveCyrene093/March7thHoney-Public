using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FDPFOINNLOMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FDPFOINNLOMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGRFBGT0lOTkxPTS5wcm90byJMCgtGRFBGT0lOTkxPTRITCgtDR09BQkdL" + "Q0JFRhgHIAEoDRITCgtEREJIQUNPUEVHRxgNIAEoDRITCgtMTEVFRkRHSkJL" + "QRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FDPFOINNLOM), FDPFOINNLOM.Parser, new string[3] { "CGOABGKCBEF", "DDBHACOPEGG", "LLEEFDGJBKA" }, null, null, null, null)
		}));
	}
}
