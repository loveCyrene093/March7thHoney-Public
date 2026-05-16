using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AHLMMDJAGOAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AHLMMDJAGOAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBSExNTURKQUdPQS5wcm90byIiCgtBSExNTURKQUdPQRITCgt0ZWxlcG9y" + "dF9pZBgKIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AHLMMDJAGOA), AHLMMDJAGOA.Parser, new string[1] { "TeleportId" }, null, null, null, null)
		}));
	}
}
