using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class IEBAILGKMLBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static IEBAILGKMLBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFJRUJBSUxHS01MQi5wcm90byI3CgtJRUJBSUxHS01MQhITCgtFRkdPTUdH" + "R0hDUBgGIAMoDRITCgtJS0VQQkVMQUNHUBgJIAMoDUIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(IEBAILGKMLB), IEBAILGKMLB.Parser, new string[2] { "EFGOMGGGHCP", "IKEPBELACGP" }, null, null, null, null)
		}));
	}
}
