using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DGFNONPBIOFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DGFNONPBIOFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFER0ZOT05QQklPRi5wcm90byIiCgtER0ZOT05QQklPRhITCgtIRUFOTExE" + "Tk5JUBgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DGFNONPBIOF), DGFNONPBIOF.Parser, new string[1] { "HEANLLDNNIP" }, null, null, null, null)
		}));
	}
}
