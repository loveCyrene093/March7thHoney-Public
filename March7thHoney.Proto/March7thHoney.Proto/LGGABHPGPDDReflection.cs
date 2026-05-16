using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LGGABHPGPDDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LGGABHPGPDDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMR0dBQkhQR1BERC5wcm90byI3CgtMR0dBQkhQR1BERBITCgtMSVBIRFBM" + "R01OUBgMIAMoDRITCgtIQ0pQRE5ET0hBTRgNIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LGGABHPGPDD), LGGABHPGPDD.Parser, new string[2] { "LIPHDPLGMNP", "HCJPDNDOHAM" }, null, null, null, null)
		}));
	}
}
