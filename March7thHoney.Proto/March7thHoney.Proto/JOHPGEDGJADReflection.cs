using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JOHPGEDGJADReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JOHPGEDGJADReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKT0hQR0VER0pBRC5wcm90byI0CgtKT0hQR0VER0pBRBITCgtHTkJMT0hN" + "UEFDTBgDIAEoDRIQCghwcm9ncmVzcxgLIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JOHPGEDGJAD), JOHPGEDGJAD.Parser, new string[2] { "GNBLOHMPACL", "Progress" }, null, null, null, null)
		}));
	}
}
