using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JMLIJLEKBEAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JMLIJLEKBEAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTUxJSkxFS0JFQS5wcm90byIiCgtKTUxJSkxFS0JFQRITCgtGS0VHTU1L" + "TkhPThgMIAEoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JMLIJLEKBEA), JMLIJLEKBEA.Parser, new string[1] { "FKEGMMKNHON" }, null, null, null, null)
		}));
	}
}
