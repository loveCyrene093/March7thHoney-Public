using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class EPLFOKKDFLBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static EPLFOKKDFLBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFFUExGT0tLREZMQi5wcm90byIlCgtFUExGT0tLREZMQhIWCg5hdmF0YXJf" + "aWRfbGlzdBgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(EPLFOKKDFLB), EPLFOKKDFLB.Parser, new string[1] { "AvatarIdList" }, null, null, null, null)
		}));
	}
}
