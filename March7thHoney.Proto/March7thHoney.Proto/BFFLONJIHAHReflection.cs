using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class BFFLONJIHAHReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static BFFLONJIHAHReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFCRkZMT05KSUhBSC5wcm90byINCgtCRkZMT05KSUhBSEIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(BFFLONJIHAH), BFFLONJIHAH.Parser, null, null, null, null, null)
		}));
	}
}
