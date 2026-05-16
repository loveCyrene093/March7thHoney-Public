using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JLAJKALOBMJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JLAJKALOBMJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTEFKS0FMT0JNSi5wcm90byIiCgtKTEFKS0FMT0JNShITCgtJQVBGSklO" + "Rk5MTxgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JLAJKALOBMJ), JLAJKALOBMJ.Parser, new string[1] { "IAPFJINFNLO" }, null, null, null, null)
		}));
	}
}
