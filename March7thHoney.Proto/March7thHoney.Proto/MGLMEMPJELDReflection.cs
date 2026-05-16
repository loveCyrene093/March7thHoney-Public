using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MGLMEMPJELDReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MGLMEMPJELDReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNR0xNRU1QSkVMRC5wcm90byIiCgtNR0xNRU1QSkVMRBITCgtERUtKSEFC" + "UEpEQRgDIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MGLMEMPJELD), MGLMEMPJELD.Parser, new string[1] { "DEKJHABPJDA" }, null, null, null, null)
		}));
	}
}
