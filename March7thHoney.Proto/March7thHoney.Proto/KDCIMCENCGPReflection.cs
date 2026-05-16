using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KDCIMCENCGPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KDCIMCENCGPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLRENJTUNFTkNHUC5wcm90byI3CgtLRENJTUNFTkNHUBITCgtMR0hPT0tN" + "Tk1DTBgCIAEoDRITCgtMQ0RBTEVFRURKShgNIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KDCIMCENCGP), KDCIMCENCGP.Parser, new string[2] { "LGHOOKMNMCL", "LCDALEEEDJJ" }, null, null, null, null)
		}));
	}
}
