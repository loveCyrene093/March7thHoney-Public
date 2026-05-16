using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HKGDGAJHJPOReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HKGDGAJHJPOReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIS0dER0FKSEpQTy5wcm90byIxCgtIS0dER0FKSEpQTxITCgtBUERBQk5H" + "RE1QTRgEIAEoDRINCgVsZXZlbBgPIAEoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HKGDGAJHJPO), HKGDGAJHJPO.Parser, new string[2] { "APDABNGDMPM", "Level" }, null, null, null, null)
		}));
	}
}
