using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GNBODNMGBDLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GNBODNMGBDLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTkJPRE5NR0JETC5wcm90byIiCgtHTkJPRE5NR0JETBITCgtHUEpISk9P" + "SUpKQxgCIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GNBODNMGBDL), GNBODNMGBDL.Parser, new string[1] { "GPJHJOOIJJC" }, null, null, null, null)
		}));
	}
}
