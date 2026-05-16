using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LBCNAOFKCILReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LBCNAOFKCILReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMQkNOQU9GS0NJTC5wcm90byJMCgtMQkNOQU9GS0NJTBITCgtHTkRFUE9L" + "RkhQRRgLIAEoDRITCgtPTU5GRE5CRVBMQRgNIAEoDRITCgtISk1HR0xBTkhN" + "TBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LBCNAOFKCIL), LBCNAOFKCIL.Parser, new string[3] { "GNDEPOKFHPE", "OMNFDNBEPLA", "HJMGGLANHML" }, null, null, null, null)
		}));
	}
}
