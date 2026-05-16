using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HADCALJHOFIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HADCALJHOFIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIQURDQUxKSE9GSS5wcm90byIlCgtIQURDQUxKSE9GSRIWCg5hdmF0YXJf" + "aWRfbGlzdBgHIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HADCALJHOFI), HADCALJHOFI.Parser, new string[1] { "AvatarIdList" }, null, null, null, null)
		}));
	}
}
