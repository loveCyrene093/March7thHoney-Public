using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NHFMHLCGJAHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NHFMHLCGJAHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSEZNSExDR0pBSC5wcm90byI3CgtOSEZNSExDR0pBSBITCgtHQ1BOQ0VE" + "QU1BQhgCIAEoDRITCgtNSEVDT0ZQR0VDQhgPIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NHFMHLCGJAH), NHFMHLCGJAH.Parser, new string[2] { "GCPNCEDAMAB", "MHECOFPGECB" }, null, null, null, null)
		}));
	}
}
