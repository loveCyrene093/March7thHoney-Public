using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class KPMIMEPEBHHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static KPMIMEPEBHHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFLUE1JTUVQRUJISC5wcm90byIlCgtLUE1JTUVQRUJISBIWCg5hdmF0YXJf" + "aWRfbGlzdBgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(KPMIMEPEBHH), KPMIMEPEBHH.Parser, new string[1] { "AvatarIdList" }, null, null, null, null)
		}));
	}
}
