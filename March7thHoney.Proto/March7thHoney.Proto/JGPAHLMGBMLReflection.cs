using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JGPAHLMGBMLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JGPAHLMGBMLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKR1BBSExNR0JNTC5wcm90byJMCgtKR1BBSExNR0JNTBITCgtNR05HUEdQ" + "UElBQRgBIAEoDRITCgtPRERGRUFFRUpKRBgEIAEoDRITCgtES0pPT0tGQ0tG" + "ThgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JGPAHLMGBML), JGPAHLMGBML.Parser, new string[3] { "MGNGPGPPIAA", "ODDFEAEEJJD", "DKJOOKFCKFN" }, null, null, null, null)
		}));
	}
}
