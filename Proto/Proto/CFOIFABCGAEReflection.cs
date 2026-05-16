using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class CFOIFABCGAEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static CFOIFABCGAEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDRk9JRkFCQ0dBRS5wcm90byJhCgtDRk9JRkFCQ0dBRRITCgtJS0xERk1C" + "R0hHQhgFIAEoDRITCgtOQUZMREpGQ0NQQxgJIAEoDRITCgtES0pGRExLSkxC" + "RRgLIAEoCBITCgtJQUhPQkdGREJNTBgOIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(CFOIFABCGAE), CFOIFABCGAE.Parser, new string[4] { "IKLDFMBGHGB", "NAFLDJFCCPC", "DKJFDLKJLBE", "IAHOBGFDBML" }, null, null, null, null)
		}));
	}
}
