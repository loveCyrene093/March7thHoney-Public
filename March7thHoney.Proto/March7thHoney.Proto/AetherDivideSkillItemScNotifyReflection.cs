using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AetherDivideSkillItemScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AetherDivideSkillItemScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CiNBZXRoZXJEaXZpZGVTa2lsbEl0ZW1TY05vdGlmeS5wcm90byI9Ch1BZXRo" + "ZXJEaXZpZGVTa2lsbEl0ZW1TY05vdGlmeRIPCgdpdGVtX2lkGAEgASgNEgsK" + "A251bRgEIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AetherDivideSkillItemScNotify), AetherDivideSkillItemScNotify.Parser, new string[2] { "ItemId", "Num" }, null, null, null, null)
		}));
	}
}
