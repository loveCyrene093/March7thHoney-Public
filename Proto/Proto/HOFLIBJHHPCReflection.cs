using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HOFLIBJHHPCReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HOFLIBJHHPCReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIT0ZMSUJKSEhQQy5wcm90byI6CgtIT0ZMSUJKSEhQQxIWCg5hdmF0YXJf" + "aWRfbGlzdBgBIAMoDRITCgtDSERQTkNPSEFHSBgCIAEoDUIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HOFLIBJHHPC), HOFLIBJHHPC.Parser, new string[2] { "AvatarIdList", "CHDPNCOHAGH" }, null, null, null, null)
		}));
	}
}
