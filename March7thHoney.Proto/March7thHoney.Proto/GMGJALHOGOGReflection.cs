using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GMGJALHOGOGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GMGJALHOGOGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTUdKQUxIT0dPRy5wcm90byIiCgtHTUdKQUxIT0dPRxITCgtGT09MTUlB" + "RE1NSBgGIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GMGJALHOGOG), GMGJALHOGOG.Parser, new string[1] { "FOOLMIADMMH" }, null, null, null, null)
		}));
	}
}
