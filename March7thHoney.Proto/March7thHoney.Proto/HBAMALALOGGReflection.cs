using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HBAMALALOGGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HBAMALALOGGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQkFNQUxBTE9HRy5wcm90byIiCgtIQkFNQUxBTE9HRxITCgtBQkdMTklE" + "T0FETRgNIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HBAMALALOGG), HBAMALALOGG.Parser, new string[1] { "ABGLNIDOADM" }, null, null, null, null)
		}));
	}
}
