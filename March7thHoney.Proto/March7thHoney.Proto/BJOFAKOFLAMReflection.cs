using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BJOFAKOFLAMReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BJOFAKOFLAMReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSk9GQUtPRkxBTS5wcm90byIiCgtCSk9GQUtPRkxBTRITCgtEQ1BLUE5M" + "S0dNTRgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BJOFAKOFLAM), BJOFAKOFLAM.Parser, new string[1] { "DCPKPNLKGMM" }, null, null, null, null)
		}));
	}
}
