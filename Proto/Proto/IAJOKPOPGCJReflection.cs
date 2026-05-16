using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IAJOKPOPGCJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IAJOKPOPGCJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJQUpPS1BPUEdDSi5wcm90byIiCgtJQUpPS1BPUEdDShITCgtJQVBGSklO" + "Rk5MTxgFIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IAJOKPOPGCJ), IAJOKPOPGCJ.Parser, new string[1] { "IAPFJINFNLO" }, null, null, null, null)
		}));
	}
}
