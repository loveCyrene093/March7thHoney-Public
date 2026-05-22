using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HMIHJIMCIEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HMIHJIMCIEAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITUlISklNQ0lFQS5wcm90byIiCgtITUlISklNQ0lFQRITCgtISVBFT0RM" + "QkJKRhgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HMIHJIMCIEA), HMIHJIMCIEA.Parser, new string[1] { "HIPEODLBBJF" }, null, null, null, null)
		}));
	}
}
