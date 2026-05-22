using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class FODKHDFFIAHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static FODKHDFFIAHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFGT0RLSERGRklBSC5wcm90byIfCgtGT0RLSERGRklBSBIQCghza2lsbF9p" + "ZBgBIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(FODKHDFFIAH), FODKHDFFIAH.Parser, new string[1] { "SkillId" }, null, null, null, null)
		}));
	}
}
