using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class OGBJNEDMMEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static OGBJNEDMMEAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFPR0JKTkVETU1FQS5wcm90byI3CgtPR0JKTkVETU1FQRITCgtMT0lKTElL" + "T01KThgBIAEoDRITCgtNR05HUEdQUElBQRgCIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(OGBJNEDMMEA), OGBJNEDMMEA.Parser, new string[2] { "LOIJLIKOMJN", "MGNGPGPPIAA" }, null, null, null, null)
		}));
	}
}
