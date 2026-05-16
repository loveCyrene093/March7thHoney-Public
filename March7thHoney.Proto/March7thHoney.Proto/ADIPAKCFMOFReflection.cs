using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ADIPAKCFMOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ADIPAKCFMOFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRElQQUtDRk1PRi5wcm90byJMCgtBRElQQUtDRk1PRhITCgtEQUlQRU5F" + "R0NCRBgBIAEoBRITCgtEQU1ITURQT0RMRBgOIAEoBRITCgtGRFBNSUdOQUZJ" + "TRgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ADIPAKCFMOF), ADIPAKCFMOF.Parser, new string[3] { "DAIPENEGCBD", "DAMHMDPODLD", "FDPMIGNAFIM" }, null, null, null, null)
		}));
	}
}
