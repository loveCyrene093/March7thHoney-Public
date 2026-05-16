using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JLMCNJKMCFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JLMCNJKMCFGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTE1DTkpLTUNGRy5wcm90byI3CgtKTE1DTkpLTUNGRxITCgtEQUlLTktB" + "TEtDTRgIIAEoCBITCgtKQUNDSkdCR0pPQRgMIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JLMCNJKMCFG), JLMCNJKMCFG.Parser, new string[2] { "DAIKNKALKCM", "JACCJGBGJOA" }, null, null, null, null)
		}));
	}
}
