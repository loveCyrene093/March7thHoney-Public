using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GridFightHandBookRoleInfoReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GridFightHandBookRoleInfoReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("Ch9HcmlkRmlnaHRIYW5kQm9va1JvbGVJbmZvLnByb3RvIlAKGUdyaWRGaWdo" + "dEhhbmRCb29rUm9sZUluZm8SHgoWZ3JpZF9maWdodF9hdmF0YXJfbGlzdBgL" + "IAMoDRITCgtMQ0dITUpGQU1FRRgNIAMoDUIWqgITTWFyY2g3dGhIb25leS5Q" + "cm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GridFightHandBookRoleInfo), GridFightHandBookRoleInfo.Parser, new string[2] { "GridFightAvatarList", "LCGHMJFAMEE" }, null, null, null, null)
		}));
	}
}
