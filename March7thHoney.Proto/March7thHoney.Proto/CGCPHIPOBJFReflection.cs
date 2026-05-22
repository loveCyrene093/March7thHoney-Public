using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CGCPHIPOBJFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CGCPHIPOBJFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDR0NQSElQT0JKRi5wcm90byIiCgtDR0NQSElQT0JKRhITCgtET01HTEhJ" + "S0pFRBgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CGCPHIPOBJF), CGCPHIPOBJF.Parser, new string[1] { "DOMGLHIKJED" }, null, null, null, null)
		}));
	}
}
