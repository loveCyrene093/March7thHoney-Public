using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HHAANBNCLHIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HHAANBNCLHIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFISEFBTkJOQ0xISS5wcm90byI3CgtISEFBTkJOQ0xISRITCgtES0pGRExL" + "SkxCRRgJIAEoCBITCgtJREtPQk1NREJIRhgKIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HHAANBNCLHI), HHAANBNCLHI.Parser, new string[2] { "DKJFDLKJLBE", "IDKOBMMDBHF" }, null, null, null, null)
		}));
	}
}
