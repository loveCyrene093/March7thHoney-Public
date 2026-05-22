using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ANHCDHLNEJNReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ANHCDHLNEJNReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTkhDREhMTkVKTi5wcm90byIiCgtBTkhDREhMTkVKThITCgtzd2l0Y2hf" + "bGlzdBgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ANHCDHLNEJN), ANHCDHLNEJN.Parser, new string[1] { "SwitchList" }, null, null, null, null)
		}));
	}
}
