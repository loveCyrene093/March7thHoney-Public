using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class NFOGBDOIEAKReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static NFOGBDOIEAKReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFORk9HQkRPSUVBSy5wcm90byINCgtORk9HQkRPSUVBS0IWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(NFOGBDOIEAK), NFOGBDOIEAK.Parser, null, null, null, null, null)
		}));
	}
}
