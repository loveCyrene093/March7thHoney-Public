using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DJFICOPFDPLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DJFICOPFDPLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFESkZJQ09QRkRQTC5wcm90byI3CgtESkZJQ09QRkRQTBITCgtOTEVBUEZG" + "QUZFRRgBIAEoDRITCgtBQ01HQk5ORUFDShgFIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DJFICOPFDPL), DJFICOPFDPL.Parser, new string[2] { "NLEAPFFAFEE", "ACMGBNNEACJ" }, null, null, null, null)
		}));
	}
}
