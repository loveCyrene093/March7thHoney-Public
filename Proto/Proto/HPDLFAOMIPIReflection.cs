using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class HPDLFAOMIPIReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static HPDLFAOMIPIReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFIUERMRkFPTUlQSS5wcm90byIlCgtIUERMRkFPTUlQSRIWCg5hdmF0YXJf" + "aWRfbGlzdBgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(HPDLFAOMIPI), HPDLFAOMIPI.Parser, new string[1] { "AvatarIdList" }, null, null, null, null)
		}));
	}
}
