using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BENODCCGBKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BENODCCGBKAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCRU5PRENDR0JLQS5wcm90byIiCgtCRU5PRENDR0JLQRITCgtET01HTEhJ" + "S0pFRBgHIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BENODCCGBKA), BENODCCGBKA.Parser, new string[1] { "DOMGLHIKJED" }, null, null, null, null)
		}));
	}
}
