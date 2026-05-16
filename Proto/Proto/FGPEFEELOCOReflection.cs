using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FGPEFEELOCOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FGPEFEELOCOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGR1BFRkVFTE9DTy5wcm90byJGCgtGR1BFRkVFTE9DTxITCgtFS0JNRUFK" + "Tk5LTxgBIAMoDRINCgVsZXZlbBgHIAEoDRITCgtLTE9PRkFFSkdLRBgMIAEo" + "DUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FGPEFEELOCO), FGPEFEELOCO.Parser, new string[3] { "EKBMEAJNNKO", "Level", "KLOOFAEJGKD" }, null, null, null, null)
		}));
	}
}
