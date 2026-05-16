using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OMLONGNOMAIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OMLONGNOMAIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPTUxPTkdOT01BSS5wcm90byJMCgtPTUxPTkdOT01BSRITCgtNS0JGSEpE" + "TUpLTBgEIAEoDRITCgtQTkpITUdORUpKSRgJIAEoDRITCgtOSU9BT0JHRk1F" + "SBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OMLONGNOMAI), OMLONGNOMAI.Parser, new string[3] { "MKBFHJDMJKL", "PNJHMGNEJJI", "NIOAOBGFMEH" }, null, null, null, null)
		}));
	}
}
