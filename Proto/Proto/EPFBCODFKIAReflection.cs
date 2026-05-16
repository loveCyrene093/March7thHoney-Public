using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPFBCODFKIAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPFBCODFKIAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUEZCQ09ERktJQS5wcm90byIiCgtFUEZCQ09ERktJQRITCgtOTUREQUZL" + "SUdERhgIIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPFBCODFKIA), EPFBCODFKIA.Parser, new string[1] { "NMDDAFKIGDF" }, null, null, null, null)
		}));
	}
}
