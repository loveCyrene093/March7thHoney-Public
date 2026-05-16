using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ADMKICHLGBPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ADMKICHLGBPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBRE1LSUNITEdCUC5wcm90byI3CgtBRE1LSUNITEdCUBITCgtERElGRUZP" + "R0dNTBgEIAEoDRITCgtGT01ORkhKQ0RPQxgJIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ADMKICHLGBP), ADMKICHLGBP.Parser, new string[2] { "DDIFEFOGGML", "FOMNFHJCDOC" }, null, null, null, null)
		}));
	}
}
