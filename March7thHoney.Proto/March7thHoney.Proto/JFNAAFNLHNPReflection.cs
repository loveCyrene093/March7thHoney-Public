using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JFNAAFNLHNPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JFNAAFNLHNPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKRk5BQUZOTEhOUC5wcm90byI3CgtKRk5BQUZOTEhOUBITCgtQR0hES0ZQ" + "R1BJSBgBIAEoDRITCgtLSkdCUENFR0ZBUBgLIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JFNAAFNLHNP), JFNAAFNLHNP.Parser, new string[2] { "PGHDKFPGPIH", "KJGBPCEGFAP" }, null, null, null, null)
		}));
	}
}
