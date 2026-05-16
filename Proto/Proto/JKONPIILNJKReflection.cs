using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JKONPIILNJKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JKONPIILNJKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKS09OUElJTE5KSy5wcm90byJGCgtKS09OUElJTE5KSxINCgV0aXRsZRgF" + "IAEoCRITCgtNT0JCUE1NS0tNSRgOIAEoDRITCgtGQ09LT0dOT0dDQRgPIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JKONPIILNJK), JKONPIILNJK.Parser, new string[3] { "Title", "MOBBPMMKKMI", "FCOKOGNOGCA" }, null, null, null, null)
		}));
	}
}
