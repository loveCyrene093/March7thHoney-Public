using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class LFKEDPPLOKLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static LFKEDPPLOKLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFMRktFRFBQTE9LTC5wcm90byIiCgtMRktFRFBQTE9LTBITCgtLSERMTVBB" + "S0VHRhgLIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(LFKEDPPLOKL), LFKEDPPLOKL.Parser, new string[1] { "KHDLMPAKEGF" }, null, null, null, null)
		}));
	}
}
