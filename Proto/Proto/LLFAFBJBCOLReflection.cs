using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LLFAFBJBCOLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LLFAFBJBCOLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMTEZBRkJKQkNPTC5wcm90byI3CgtMTEZBRkJKQkNPTBITCgtESk1QTERL" + "R0FERxgFIAMoDRITCgtPRkhDTkdISkZISRgHIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LLFAFBJBCOL), LLFAFBJBCOL.Parser, new string[2] { "DJMPLDKGADG", "OFHCNGHJFHI" }, null, null, null, null)
		}));
	}
}
