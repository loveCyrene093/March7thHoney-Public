using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ALABNDBMKBIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ALABNDBMKBIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTEFCTkRCTUtCSS5wcm90byIiCgtBTEFCTkRCTUtCSRITCgtET01HTEhJ" + "S0pFRBgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ALABNDBMKBI), ALABNDBMKBI.Parser, new string[1] { "DOMGLHIKJED" }, null, null, null, null)
		}));
	}
}
