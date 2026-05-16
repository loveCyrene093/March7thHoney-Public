using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MDFEFKDEFMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MDFEFKDEFMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNREZFRktERUZNTC5wcm90byI0CgtNREZFRktERUZNTBIQCghzdGFnZV9p" + "ZBgMIAEoDRITCgtCUE5CTlBHUEZKSxgNIAEoDUIWqgITTWFyY2g3dGhIb25l" + "eS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MDFEFKDEFML), MDFEFKDEFML.Parser, new string[2] { "StageId", "BPNBNPGPFJK" }, null, null, null, null)
		}));
	}
}
