using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class ANINPOGOEDJReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static ANINPOGOEDJReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFBTklOUE9HT0VESi5wcm90byINCgtBTklOUE9HT0VESkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(ANINPOGOEDJ), ANINPOGOEDJ.Parser, null, null, null, null, null)
		}));
	}
}
