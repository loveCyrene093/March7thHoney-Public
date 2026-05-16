using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MKOPHCBPOMMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MKOPHCBPOMMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNS09QSENCUE9NTS5wcm90byIiCgtNS09QSENCUE9NTRITCgtLUEpHRUdN" + "Q0NBRxgEIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MKOPHCBPOMM), MKOPHCBPOMM.Parser, new string[1] { "KPJGEGMCCAG" }, null, null, null, null)
		}));
	}
}
