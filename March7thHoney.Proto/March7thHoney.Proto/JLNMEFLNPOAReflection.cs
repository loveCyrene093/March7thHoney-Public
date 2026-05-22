using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JLNMEFLNPOAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JLNMEFLNPOAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKTE5NRUZMTlBPQS5wcm90byIiCgtKTE5NRUZMTlBPQRITCgtKRU1FQkxG" + "QU5MTRgKIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JLNMEFLNPOA), JLNMEFLNPOA.Parser, new string[1] { "JEMEBLFANLM" }, null, null, null, null)
		}));
	}
}
