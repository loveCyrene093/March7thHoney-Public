using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BHFONEFGGAGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BHFONEFGGAGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCSEZPTkVGR0dBRy5wcm90byIuCgtCSEZPTkVGR0dBRxIKCgJpZBgBIAEo" + "DRITCgtBRkRGT0NMREVOTRgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BHFONEFGGAG), BHFONEFGGAG.Parser, new string[2] { "Id", "AFDFOCLDENM" }, null, null, null, null)
		}));
	}
}
