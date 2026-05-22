using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class MALLAGHCFFLReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static MALLAGHCFFLReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFNQUxMQUdIQ0ZGTC5wcm90byIiCgtNQUxMQUdIQ0ZGTBITCgtMRUNGS0dM" + "RUtDShgBIAMoDUIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(MALLAGHCFFL), MALLAGHCFFL.Parser, new string[1] { "LECFKGLEKCJ" }, null, null, null, null)
		}));
	}
}
