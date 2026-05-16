using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ALEOILCIFINReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ALEOILCIFINReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTEVPSUxDSUZJTi5wcm90byIiCgtBTEVPSUxDSUZJThITCgtNRk9GRkZO" + "SUdEUBgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ALEOILCIFIN), ALEOILCIFIN.Parser, new string[1] { "MFOFFFNIGDP" }, null, null, null, null)
		}));
	}
}
