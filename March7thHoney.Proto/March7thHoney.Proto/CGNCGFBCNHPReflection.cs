using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CGNCGFBCNHPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CGNCGFBCNHPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDR05DR0ZCQ05IUC5wcm90byIiCgtDR05DR0ZCQ05IUBITCgtDSEVIRUxQ" + "TUFJQRgOIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CGNCGFBCNHP), CGNCGFBCNHP.Parser, new string[1] { "CHEHELPMAIA" }, null, null, null, null)
		}));
	}
}
