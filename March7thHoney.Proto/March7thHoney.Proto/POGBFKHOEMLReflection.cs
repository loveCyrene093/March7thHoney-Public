using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class POGBFKHOEMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static POGBFKHOEMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFQT0dCRktIT0VNTC5wcm90byIiCgtQT0dCRktIT0VNTBITCgtCSkpPQ0xJ" + "Tk1FShgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(POGBFKHOEML), POGBFKHOEML.Parser, new string[1] { "BJJOCLINMEJ" }, null, null, null, null)
		}));
	}
}
