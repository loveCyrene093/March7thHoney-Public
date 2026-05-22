using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class AvatarSpecialSkilltreeUnlockScNotifyReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static AvatarSpecialSkilltreeUnlockScNotifyReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("CipBdmF0YXJTcGVjaWFsU2tpbGx0cmVlVW5sb2NrU2NOb3RpZnkucHJvdG8i" + "SwokQXZhdGFyU3BlY2lhbFNraWxsdHJlZVVubG9ja1NjTm90aWZ5EhEKCWF2" + "YXRhcl9pZBgGIAEoDRIQCghwb2ludF9pZBgOIAEoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(AvatarSpecialSkilltreeUnlockScNotify), AvatarSpecialSkilltreeUnlockScNotify.Parser, new string[2] { "AvatarId", "PointId" }, null, null, null, null)
		}));
	}
}
