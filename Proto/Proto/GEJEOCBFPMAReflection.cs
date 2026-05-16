using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GEJEOCBFPMAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GEJEOCBFPMAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHRUpFT0NCRlBNQS5wcm90byIiCgtHRUpFT0NCRlBNQRITCgtGRU9KSUxO" + "SkVNTRgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GEJEOCBFPMA), GEJEOCBFPMA.Parser, new string[1] { "FEOJILNJEMM" }, null, null, null, null)
		}));
	}
}
