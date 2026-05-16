using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NKLOBAKEMIIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NKLOBAKEMIIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOS0xPQkFLRU1JSS5wcm90byIiCgtOS0xPQkFLRU1JSRITCgtERE1LQ09C" + "T01OTxgMIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NKLOBAKEMII), NKLOBAKEMII.Parser, new string[1] { "DDMKCOBOMNO" }, null, null, null, null)
		}));
	}
}
