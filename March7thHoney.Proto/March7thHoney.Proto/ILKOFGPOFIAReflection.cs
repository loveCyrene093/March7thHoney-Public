using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ILKOFGPOFIAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ILKOFGPOFIAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJTEtPRkdQT0ZJQS5wcm90byJMCgtJTEtPRkdQT0ZJQRITCgtNT0JQTk5N" + "R0lDQxgEIAEoDRITCgtPUEFMS0lKTUdMSBgOIAEoDRITCgtES0dOQ05LUEdL" + "RBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ILKOFGPOFIA), ILKOFGPOFIA.Parser, new string[3] { "MOBPNNMGICC", "OPALKIJMGLH", "DKGNCNKPGKD" }, null, null, null, null)
		}));
	}
}
