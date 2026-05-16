using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IPBGEGBFFHKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IPBGEGBFFHKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJUEJHRUdCRkZISy5wcm90bxoRSEZITUlLSUZMUE8ucHJvdG8iMAoLSVBC" + "R0VHQkZGSEsSIQoLYXZhdGFyX2xpc3QYBSADKAsyDC5IRkhNSUtJRkxQT0IW" + "qgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[1] { HFHMIKIFLPOReflection.Descriptor }, new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IPBGEGBFFHK), IPBGEGBFFHK.Parser, new string[1] { "AvatarList" }, null, null, null, null)
		}));
	}
}
