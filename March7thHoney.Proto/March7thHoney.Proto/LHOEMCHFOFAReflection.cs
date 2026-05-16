using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LHOEMCHFOFAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LHOEMCHFOFAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMSE9FTUNIRk9GQS5wcm90byIiCgtMSE9FTUNIRk9GQRITCgtFRkdCRkxN" + "TU9LSRgJIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LHOEMCHFOFA), LHOEMCHFOFA.Parser, new string[1] { "EFGBFLMMOKI" }, null, null, null, null)
		}));
	}
}
