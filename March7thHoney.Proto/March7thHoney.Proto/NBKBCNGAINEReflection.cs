using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NBKBCNGAINEReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NBKBCNGAINEReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOQktCQ05HQUlORS5wcm90byI3CgtOQktCQ05HQUlORRITCgt0YXJnZXRf" + "c2lkZRgCIAEoDRITCgtLS0ZESlBOUEJGTBgEIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NBKBCNGAINE), NBKBCNGAINE.Parser, new string[2] { "TargetSide", "KKFDJPNPBFL" }, null, null, null, null)
		}));
	}
}
