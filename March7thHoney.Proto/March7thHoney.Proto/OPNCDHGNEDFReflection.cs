using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OPNCDHGNEDFReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OPNCDHGNEDFReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPUE5DREhHTkVERi5wcm90byI3CgtPUE5DREhHTkVERhITCgtQTkZCSEhC" + "TEFGSBgKIAEoDRITCgtQT05PQkpKT0FESRgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OPNCDHGNEDF), OPNCDHGNEDF.Parser, new string[2] { "PNFBHHBLAFH", "PONOBJJOADI" }, null, null, null, null)
		}));
	}
}
