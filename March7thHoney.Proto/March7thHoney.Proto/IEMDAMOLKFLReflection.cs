using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IEMDAMOLKFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IEMDAMOLKFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRU1EQU1PTEtGTC5wcm90byIiCgtJRU1EQU1PTEtGTBITCgtFS0lNTElB" + "TUZIRRgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IEMDAMOLKFL), IEMDAMOLKFL.Parser, new string[1] { "EKIMLIAMFHE" }, null, null, null, null)
		}));
	}
}
