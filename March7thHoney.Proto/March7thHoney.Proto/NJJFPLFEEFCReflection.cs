using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NJJFPLFEEFCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NJJFPLFEEFCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFOSkpGUExGRUVGQy5wcm90byI3CgtOSkpGUExGRUVGQxITCgtKSEVJRExK" + "RUlCRBgCIAEoDRITCgtIQklLUFBLQU5DSBgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NJJFPLFEEFC), NJJFPLFEEFC.Parser, new string[2] { "JHEIDLJEIBD", "HBIKPPKANCH" }, null, null, null, null)
		}));
	}
}
