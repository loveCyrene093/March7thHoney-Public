using System;
using Google.Protobuf.Reflection;

namespace March7thHoney.Proto;

public static class JAIELCIAKANReflection
{
	private static FileDescriptor descriptor;

	public static FileDescriptor Descriptor => descriptor;

	static JAIELCIAKANReflection()
	{
		descriptor = FileDescriptor.FromGeneratedCode(Convert.FromBase64String("ChFKQUlFTENJQUtBTi5wcm90byINCgtKQUlFTENJQUtBTkIWqgITTWFyY2g3" + "dGhIb25leS5Qcm90b2IGcHJvdG8z"), new FileDescriptor[0], new GeneratedClrTypeInfo(null, null, new GeneratedClrTypeInfo[1]
		{
			new GeneratedClrTypeInfo(typeof(JAIELCIAKAN), JAIELCIAKAN.Parser, null, null, null, null, null)
		}));
	}
}
