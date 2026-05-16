using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OIDHAGNGKLGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OIDHAGNGKLGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPSURIQUdOR0tMRy5wcm90byIuCgtPSURIQUdOR0tMRxIJCgF4GAEgASgF" + "EgkKAXoYAiABKAUSCQoBeRgMIAEoBUIWqgITTWFyY2g3dGhIb25leS5Qcm90" + "b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OIDHAGNGKLG), OIDHAGNGKLG.Parser, new string[3] { "X", "Z", "Y" }, null, null, null, null)
		}));
	}
}
