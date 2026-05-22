using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCFAJAMPDKFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCFAJAMPDKFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ0ZBSkFNUERLRi5wcm90byI3CgtCQ0ZBSkFNUERLRhITCgtCR05MT0FF" + "RENPShgJIAEoDRITCgtGT09MTUlBRE1NSBgKIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCFAJAMPDKF), BCFAJAMPDKF.Parser, new string[2] { "BGNLOAEDCOJ", "FOOLMIADMMH" }, null, null, null, null)
		}));
	}
}
