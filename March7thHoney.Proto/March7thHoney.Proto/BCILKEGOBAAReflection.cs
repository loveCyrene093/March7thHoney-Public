using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BCILKEGOBAAReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BCILKEGOBAAReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCQ0lMS0VHT0JBQS5wcm90byIiCgtCQ0lMS0VHT0JBQRITCgtBT01LQ01O" + "TUlKTxgEIAEoCEIWqgITTWFyY2g3dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BCILKEGOBAA), BCILKEGOBAA.Parser, new string[1] { "AOMKCMNMIJO" }, null, null, null, null)
		}));
	}
}
