using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MNBHEHAMOKLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MNBHEHAMOKLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNTkJIRUhBTU9LTC5wcm90byJ2CgtNTkJIRUhBTU9LTBITCgtDSENORURO" + "Q0lEShgCIAEoCBITCgtDUE9HREtBTEdPTRgDIAEoCBITCgtGSUpOQVBOSUNK" + "RhgGIAEoCBITCgtOSExLRkJPQkRPTRgNIAEoCBITCgtMUEVQSUROSkRFTRgO" + "IAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MNBHEHAMOKL), MNBHEHAMOKL.Parser, new string[5] { "CHCNEDNCIDJ", "CPOGDKALGOM", "FIJNAPNICJF", "NHLKFBOBDOM", "LPEPIDNJDEM" }, null, null, null, null)
		}));
	}
}
