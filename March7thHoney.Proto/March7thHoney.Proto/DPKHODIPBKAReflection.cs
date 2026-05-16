using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DPKHODIPBKAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DPKHODIPBKAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFEUEtIT0RJUEJLQS5wcm90byI3CgtEUEtIT0RJUEJLQRITCgtPTEtNSUxO" + "R1BOThgBIAEoCBITCgtNQUZNQ0lQQUlLSxgEIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DPKHODIPBKA), DPKHODIPBKA.Parser, new string[2] { "OLKMILNGPNN", "MAFMCIPAIKK" }, null, null, null, null)
		}));
	}
}
