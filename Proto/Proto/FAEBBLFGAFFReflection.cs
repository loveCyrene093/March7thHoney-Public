using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FAEBBLFGAFFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FAEBBLFGAFFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGQUVCQkxGR0FGRi5wcm90byI3CgtGQUVCQkxGR0FGRhITCgtNS0ROT0NK" + "QkZCRxgBIAEoDRITCgtOUEVQQkJQTUlKSBgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FAEBBLFGAFF), FAEBBLFGAFF.Parser, new string[2] { "MKDNOCJBFBG", "NPEPBBPMIJH" }, null, null, null, null)
		}));
	}
}
