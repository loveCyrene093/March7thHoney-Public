using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ICOIMHLBMFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ICOIMHLBMFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQ09JTUhMQk1GSS5wcm90byIiCgtJQ09JTUhMQk1GSRITCgtBUERBQk5H" + "RE1QTRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ICOIMHLBMFI), ICOIMHLBMFI.Parser, new string[1] { "APDABNGDMPM" }, null, null, null, null)
		}));
	}
}
