using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class GLOONOCCEFGReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static GLOONOCCEFGReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFHTE9PTk9DQ0VGRy5wcm90byIiCgtHTE9PTk9DQ0VGRxITCgtJS0dETkdG" + "SU9JSxgKIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(GLOONOCCEFG), GLOONOCCEFG.Parser, new string[1] { "IKGDNGFIOIK" }, null, null, null, null)
		}));
	}
}
