using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DEOEOJBLIBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DEOEOJBLIBPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFERU9FT0pCTElCUC5wcm90byIiCgtERU9FT0pCTElCUBITCgtPR09OSk9H" + "RERJRRgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DEOEOJBLIBP), DEOEOJBLIBP.Parser, new string[1] { "OGONJOGDDIE" }, null, null, null, null)
		}));
	}
}
