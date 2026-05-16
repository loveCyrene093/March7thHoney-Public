using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NDPGKDLGBFBReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NDPGKDLGBFBReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORFBHS0RMR0JGQi5wcm90byI3CgtORFBHS0RMR0JGQhITCgtBQkhITk5L" + "QkFGUBgFIAEoDRITCgtDRUJQQUpBQUpQUBgLIAEoCEIWqgITTWFyY2g3dGhI" + "b25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NDPGKDLGBFB), NDPGKDLGBFB.Parser, new string[2] { "ABHHNNKBAFP", "CEBPAJAAJPP" }, null, null, null, null)
		}));
	}
}
