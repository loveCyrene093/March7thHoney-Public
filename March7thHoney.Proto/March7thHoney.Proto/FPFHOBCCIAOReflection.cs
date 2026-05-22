using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FPFHOBCCIAOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FPFHOBCCIAOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGUEZIT0JDQ0lBTy5wcm90byJbCgtGUEZIT0JDQ0lBTxINCgVsZXZlbBgB" + "IAEoDRITCgtHUE9MR0lHTlBJQxgGIAEoDRITCgtLTEFBRkVJTUFNSRgIIAEo" + "DRITCgtMSkJISElESUxPThgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FPFHOBCCIAO), FPFHOBCCIAO.Parser, new string[4] { "Level", "GPOLGIGNPIC", "KLAAFEIMAMI", "LJBHHIDILON" }, null, null, null, null)
		}));
	}
}
