using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class COEOHEBFICOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static COEOHEBFICOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFDT0VPSEVCRklDTy5wcm90byIiCgtDT0VPSEVCRklDTxITCgtCRkJJSVBN" + "QkZIRhgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(COEOHEBFICO), COEOHEBFICO.Parser, new string[1] { "BFBIIPMBFHF" }, null, null, null, null)
		}));
	}
}
