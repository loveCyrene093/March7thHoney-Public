using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BPONIDHOFPPReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BPONIDHOFPPReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCUE9OSURIT0ZQUC5wcm90byIlCgtCUE9OSURIT0ZQUBIWCg5hdmF0YXJf" + "aWRfbGlzdBgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BPONIDHOFPP), BPONIDHOFPP.Parser, new string[1] { "AvatarIdList" }, null, null, null, null)
		}));
	}
}
