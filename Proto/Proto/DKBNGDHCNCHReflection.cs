using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class DKBNGDHCNCHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static DKBNGDHCNCHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFES0JOR0RIQ05DSC5wcm90byI3CgtES0JOR0RIQ05DSBITCgtQTk9DS01F" + "TUhMSxgDIAEoDRITCgtLS0lPSUZMSkVFTBgGIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(DKBNGDHCNCH), DKBNGDHCNCH.Parser, new string[2] { "PNOCKMEMHLK", "KKIOIFLJEEL" }, null, null, null, null)
		}));
	}
}
