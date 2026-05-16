using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FPLCHBNNAHDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FPLCHBNNAHDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGUExDSEJOTkFIRC5wcm90byIiCgtGUExDSEJOTkFIRBITCgtJSU1ORk1M" + "TENNTBgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FPLCHBNNAHD), FPLCHBNNAHD.Parser, new string[1] { "IIMNFMLLCML" }, null, null, null, null)
		}));
	}
}
