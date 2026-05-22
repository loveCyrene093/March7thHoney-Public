using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HGOILCGHKNMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HGOILCGHKNMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIR09JTENHSEtOTS5wcm90byIiCgtIR09JTENHSEtOTRITCgtIS0xKRkxI" + "UEpDRRgFIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HGOILCGHKNM), HGOILCGHKNM.Parser, new string[1] { "HKLJFLHPJCE" }, null, null, null, null)
		}));
	}
}
