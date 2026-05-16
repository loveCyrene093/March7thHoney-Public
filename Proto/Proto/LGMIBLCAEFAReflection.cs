using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGMIBLCAEFAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGMIBLCAEFAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMR01JQkxDQUVGQS5wcm90byJGCgtMR01JQkxDQUVGQRITCgtCT0ZPTUFQ" + "S0tITRgCIAMoDRITCgtLTE9PRkFFSkdLRBgHIAEoDRINCgVsZXZlbBgKIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LGMIBLCAEFA), LGMIBLCAEFA.Parser, new string[3] { "BOFOMAPKKHM", "KLOOFAEJGKD", "Level" }, null, null, null, null)
		}));
	}
}
