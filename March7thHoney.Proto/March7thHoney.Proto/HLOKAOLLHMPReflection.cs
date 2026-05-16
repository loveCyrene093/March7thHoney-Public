using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HLOKAOLLHMPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HLOKAOLLHMPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFITE9LQU9MTEhNUC5wcm90byI3CgtITE9LQU9MTEhNUBITCgtPRkhDTkdI" + "SkZISRgEIAEoDRITCgtBQ1BCT0hDSEhLRxgFIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HLOKAOLLHMP), HLOKAOLLHMP.Parser, new string[2] { "OFHCNGHJFHI", "ACPBOHCHHKG" }, null, null, null, null)
		}));
	}
}
