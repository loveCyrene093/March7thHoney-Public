using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OPPNAHLPAFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OPPNAHLPAFGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPUFBOQUhMUEFGRy5wcm90byIiCgtPUFBOQUhMUEFGRxITCgtESU5NS0VJ" + "SU5MTRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OPPNAHLPAFG), OPPNAHLPAFG.Parser, new string[1] { "DINMKEIINLM" }, null, null, null, null)
		}));
	}
}
