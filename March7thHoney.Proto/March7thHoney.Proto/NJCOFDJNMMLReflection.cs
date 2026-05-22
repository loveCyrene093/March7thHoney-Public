using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NJCOFDJNMMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NJCOFDJNMMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSkNPRkRKTk1NTC5wcm90byI3CgtOSkNPRkRKTk1NTBITCgtQT09FRk5E" + "UEVJTBgBIAEoDRITCgtORkdKSURBRExFRBgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NJCOFDJNMML), NJCOFDJNMML.Parser, new string[2] { "POOEFNDPEIL", "NFGJIDADLED" }, null, null, null, null)
		}));
	}
}
